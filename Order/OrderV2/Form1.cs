using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderV2
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb; //儲存資料庫連繫字串的物件
        int Ordernumber;
        List<string> myList1 = new List<string>();  
        List<string> myList2 = new List<string>();  //1 price  2detail  3name  4id
        List<string> myList3 = new List<string>();
        List<string> myList4 = new List<string>();
        //string C_id = "";
        //string p_price, p_detail, p_name, p_id;
        string price = " ";
        string detail = " ";
        string p_name, p_id = "";
        int Subtotal;  //小計 ,總計
        string O_id =" ";   //orderid暫存
        string i_id =" ";   //itemid暫存
        string TotalPrice = "";//totalprice暫存


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter1.Fill(this.orderSystem1DataSet2.Products);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.OrderDetail' 資料表。您可以視需要進行移動或移除。
            this.orderDetailTableAdapter1.Fill(this.orderSystem1DataSet2.OrderDetail);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.OrderMaster' 資料表。您可以視需要進行移動或移除。
            this.orderMasterTableAdapter.Fill(this.orderSystem1DataSet2.OrderMaster);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.SingleDetail' 資料表。您可以視需要進行移動或移除。
            this.singleDetailTableAdapter1.Fill(this.orderSystem1DataSet2.SingleDetail);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter1.Fill(this.orderSystem1DataSet2.Customers);

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"(localdb)\DeptLocalDB";
            scsb.InitialCatalog = "OrderSystem1";
            scsb.IntegratedSecurity = true;

            showDataGridViewCustomers1();
            //showOrderDetailDataGridView2();
           //        displayTime();


        }

        //        private void displayTime()
        //        {
        //            lblCuerrentNow1.Text = DateTime.Now.ToString();
        //        }


        //顯示DataGridViewCustomers1
        private void showDataGridViewCustomers1()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select top 100 *  from Customers";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();   //會回傳查詢資料並存在data中

            if (reader.HasRows)   //hasrows 有的話才執行
            {//建立新元件讓資料顯示在gridview上 
                DataTable dt = new DataTable();
                dt.Load(reader);  //載入資料
                DataGridViewCustomer1.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }


        //客戶資料搜尋
        private void btnSearchCustomer1_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.Text.Length > 0)  //用姓名來搜尋
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                //String strSQL = "select top 100 * from Customers where CustomerName=@SearchName";
                String strSQL = "select top 100 * from Customers where CustomerName = LTRIM(@SearchName)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tbCustomerName.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbCustomerName.Text = string.Format("{0}", reader["CustomerName"]);
                    tbCustomerPhone.Text = string.Format("{0}", reader["CustomerPhone"]);
                    tbCustomerAddress.Text = string.Format("{0}", reader["CustomerAddress"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    tbCustomerName.Text = "";
                    tbCustomerPhone.Text = "";
                    tbCustomerAddress.Text = "";
                }
                reader.Close();
                con.Close();
            }
            else if (tbCustomerPhone.Text.Length > 0)   //用電話來搜尋
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                String strSQL = "select top 100 * from Customers where CustomerPhone= = LTRIM(@SearchtbCustomerPhone)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchtbCustomerPhone", tbCustomerPhone.Text);
                SqlDataReader reader = cmd.ExecuteReader();
       //         MessageBox.Show(reader.Read().ToString());

                if (reader.Read())
                {
                    tbCustomerName.Text = string.Format("{0}", reader["CustomerName"]);
                    tbCustomerPhone.Text = string.Format("{0}", reader["CustomerPhone"]);
                    tbCustomerAddress.Text = string.Format("{0}", reader["CustomerAddress"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    tbCustomerName.Text = "";
                    tbCustomerPhone.Text = "";
                    tbCustomerAddress.Text = "";
                }
                reader.Close();
                con.Close();
            }
            else {
                MessageBox.Show("請輸入姓名搜尋");
            }


        }



        //更新客戶資料
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update Customers set CustomerPhone=@NewCustomerPhone, CustomerAddress=@NewCustomerAddress where CustomerName=@SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tbCustomerName.Text);
                cmd.Parameters.AddWithValue("@NewCustomerPhone", tbCustomerPhone.Text);
                cmd.Parameters.AddWithValue("@NewCustomerAddress", tbCustomerAddress.Text);

                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));

            }
            else {
                MessageBox.Show("請輸入姓名搜尋");
            }
            showDataGridViewCustomers1();
        }

        //新增客戶
        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Customers values(" + "@NewName,@NewCustomerPhone,@NewCustomerAddress,@NewReferee)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", tbCustomerName.Text);
                cmd.Parameters.AddWithValue("@NewCustomerPhone", tbCustomerPhone.Text);
                cmd.Parameters.AddWithValue("@NewCustomerAddress", tbCustomerAddress.Text);
                cmd.Parameters.AddWithValue("@NewReferee", tbReferee1.Text);

                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
            }
            else {
                MessageBox.Show("請新增姓名電話地址");
            }
            showDataGridViewCustomers1();
        }







        //訂購數量增加按鈕
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Ordernumber++;
            btnPlus.Enabled = true;
            tbOrderNumber.Text = Convert.ToString(Ordernumber);
            Subtotals();
            //Subtotal1(Subtotal);
        }

        //訂購數量減少按鈕
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Ordernumber--;
            if (Ordernumber < 0)
            {
                Ordernumber = 0;
                btnPlus.Enabled = false;
            }
            tbOrderNumber.Text = Convert.ToString(Ordernumber);
            Subtotals();
            //Subtotal1(Subtotal);
        }

        //訂購物品選擇
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbOrderNumber.Text = "";
            tbSubtotal.Text = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@SearchtbProductName", lblPrice.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("請選擇產品名稱");
            }
            while (reader.Read())
            {
                price = string.Format("{0}", reader["ProductPrice"]);
                detail = string.Format("{0}", reader["ProductDetail"]);
                p_name = string.Format("{0}", reader["ProductName"]);
                p_id = string.Format("{0}", reader["ProductId"]);
                myList1.Add(price);
                myList2.Add(detail);
                myList3.Add(p_name);
                myList4.Add(p_id);
            }
            /*foreach (string a in myList)
            {
                MessageBox.Show(a);
            }*/

            lblPrice.Text = myList1[comboBox1.SelectedIndex];
            lblDetail.Text = myList2[comboBox1.SelectedIndex]; 
            lblp_name.Text = myList3[comboBox1.SelectedIndex];
            lblp_id.Text = myList4[comboBox1.SelectedIndex];
        }

        
        //訂購物品小計
        private void Subtotals()
        {       
            Subtotal = Ordernumber * int.Parse(myList1[comboBox1.SelectedIndex]);
            tbSubtotal.Text = string.Format("{0}", Subtotal);
        }


       //public string LoginId = tbLoginId.Text();
        
       //後台管理登錄  登入form2未做
        private void buttonLogin_Click(object sender, EventArgs e)  
        {

            bool ifUserRight = false;  //建立兩個變數檢查帳號密碼的變數，再用迴圈檢測
            bool ifPasswordRight = false;

            if (tbLoginId.Text == "boss") 
                {
                    ifUserRight = true;

                    if (tbpassword.Text == "1234")
                    {
                        ifPasswordRight = true;
                        //break;
                    }
                }
            

            if ((tbLoginId.Text ==" ") || (tbpassword.Text ==" "))  //帳號有輸入不能空白
            {
                MessageBox.Show("帳號密碼請勿空白");
            }
            else
            {
                if (ifUserRight && ifPasswordRight)//登入成功
                {
                    Form2 myform2 = new Form2();
                    myform2.ShowDialog();  //只能開一個 
                                   //登入form2未做
                }
                else    //登入失敗
                {
                    if (ifUserRight == false)
                    {
                        MessageBox.Show("登入帳號有誤");
                    }
                    else
                    {
                        MessageBox.Show("登入密碼有誤");
                    }
                }

            }

            
        }
        
        //關閉form1
        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            //Application.Exit();//結束程序   bug
            //this.Close(); //關閉視窗     bug
            System.Environment.Exit(System.Environment.ExitCode);
        }





        
        //開始訂購
        private void buttonStartOrder_Click(object sender, EventArgs e)
        {
            if (tbCustomerPhone.TextLength != 0  )
            {
                //resetitemid();
                string C_id = "";
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                //先取得CustomerId
                string strSQL = "select CustomerId from Customers where CustomerPhone=@SearchPhone";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchPhone", tbCustomerPhone.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                //MessageBox.Show(reader.Read().ToString()); //true 有對上
               if (reader.Read())
                {
                    C_id = string.Format("{0}", reader["CustomerId"]);
                    //MessageBox.Show("CustomerId:"+ C_id);
                }
                else
                {
                  //  MessageBox.Show("NO");
                }
 
                insertOrderMasterDetail(C_id); //訂單主檔明細新增
                showorderMasterDataGridView();
                //showOrderDetailDataGridView2();
                panelStart.Visible = false;   //panel消失
 
            }
            else{
                MessageBox.Show("請先確認訂購者姓名與電話");
            }

            resetitemid();


        }

        //重置ItemId
        private void resetitemid()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "DBCC CHECKIDENT(OrderDetail, RESEED, 0) ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //int rows2 = 
            cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
            con.Close();
            //  MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));
        }



        //新增訂單主檔
        private void insertOrderMasterDetail(string C_id) 
        {
               SqlConnection con2 = new SqlConnection(scsb.ToString());
               con2.Open();
               string strSQL2 = "insert into [dbo].[OrderMaster] ([CustomerId],[OrderDate])" + "values(@NewCustomerId,@NewOrderDate)";
               SqlCommand cmd2 = new SqlCommand(strSQL2, con2);

               cmd2.Parameters.AddWithValue("@NewCustomerId", C_id);
               //MessageBox.Show(C_id);// Convert.ToInt32(C_id)
               cmd2.Parameters.AddWithValue("@NewOrderDate", (DateTime)dtpOrderTime1.Value);
               //MessageBox.Show(dtpOrderTime1.ToString());
               //cmd2.Parameters.AddWithValue("@NewPickup", (bool)chkDelivery.Checked);

              int rows = cmd2.ExecuteNonQuery();
               con2.Close();
               showorderMasterDataGridView();
               

        }


        //顯示orderMasterDataGridView
        private void showorderMasterDataGridView()  
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select top 100 *  from OrderMaster  ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();   //會回傳查詢資料並存在data中

            if (reader.HasRows)   //hasrows 有的話才執行
            {//建立新元件讓資料顯示在gridview上 
                DataTable dt = new DataTable();
                dt.Load(reader);  //載入資料
                orderMasterDataGridView.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }


        //取得orderid
        private void getorderid()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //先取得orderId
            // string strSQL3 = "select OrderId from OrderMaster where OrderDate=@NewOrderDate";
            string strSQL3 = "Select max(OrderId) as OrderId from OrderMaster";
            SqlCommand cmd = new SqlCommand(strSQL3, con);
            //cmd.Parameters.AddWithValue("@NewOrderDate", (DateTime)dtpOrderTime1.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            //MessageBox.Show(reader.Read().ToString()); //true 有對上
            if (reader.Read())
            {
                O_id = string.Format("{0}", reader["OrderId"]);
                //MessageBox.Show("searchOrderId:" + O_id);
            }
            else
            {
                MessageBox.Show("未取得orderid");
            }
            
        }


        //產生訂單明細內容
        private void buttonOrderDetailStart_Click(object sender, EventArgs e)
        {
                
               getorderid();
              
               SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into [dbo].[OrderDetail]([OrderId],[ProductId],[ProductName],[ProductPrice],Quantity,SubTotal)" + "values(@NewOrderId,@NewProductId,@NewProductName,@NewProductPrice,@NewQuantity,@NewSubtotal)" ;
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewOrderId", O_id);
                //MessageBox.Show("輸入orderid  " + O_id);
                cmd.Parameters.AddWithValue("@NewProductId", lblp_id.Text);
                //MessageBox.Show("輸入p_id: "+ lblp_id.Text);
                cmd.Parameters.AddWithValue("@NewProductName", lblp_name.Text);
                //MessageBox.Show(" 輸入p_name  " + lblp_name.Text);
                cmd.Parameters.AddWithValue("@NewProductPrice", lblPrice.Text);
                //MessageBox.Show("輸入lblPrice  " + lblPrice.Text);
                cmd.Parameters.AddWithValue("@NewQuantity", tbOrderNumber.Text);
                //MessageBox.Show("輸入tbOrderNumber  " + tbOrderNumber.Text);
                cmd.Parameters.AddWithValue("@NewSubtotal", tbSubtotal.Text);
                //MessageBox.Show("輸tbSubtotal  " + tbSubtotal.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                //showorderDetailDataGridView();
                showOrderDetailDataGridView2();
                gettotalprice(); //計算總價
                tbOrderNumber.Text = "";
                tbSubtotal.Text = "";
        }

        //計算總價
        private void gettotalprice()
        {
            //MessageBox.Show("計算訂單總價來源O_id"+O_id);

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //先取得orderId
            string strSQL = "select sum(SubTotal) as sumtt from OrderDetail" + " where OrderID = @SearchOrderId";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@SearchOrderId", O_id);
          
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tbTotalPrice.Text = string.Format("{0}", reader["sumtt"]);
            }
            else
            {
                MessageBox.Show("no計算總價錯誤");
            }

   
        }



        //確認訂單
        private void buttonOrderClear_Click(object sender, EventArgs e)
        {

            resetitemid(); //更新itemid


            //更新(確認)訂單取貨總價
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "update OrderMaster set PickUp = @NewPickUp, TotalPrice = @NewTotalPrice, Pay = @NewPay" + " where OrderId = @SearchOrderId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchOrderId", O_id);
           // MessageBox.Show("訂單"+ O_id);
            cmd.Parameters.AddWithValue("@NewPickUp", (bool)chkDelivery.Checked);
            //MessageBox.Show("宅配" + chkDelivery.Checked.ToString());
            cmd.Parameters.AddWithValue("@NewTotalPrice", tbTotalPrice.Text);
            //MessageBox.Show(tbTotalPrice.Text);
            cmd.Parameters.AddWithValue("@NewPay", (bool)chkPay.Checked);
            int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
            con.Close();


            MessageBox.Show("您的訂單編號"+ O_id + "\n總價  " + tbTotalPrice.Text + "元");

            clearall();
            //O_id = "";
            //
            this.OrderDetailDataGridView2.EndEdit();
            //MessageBox.Show("儲存完畢"+ "/nO_id"+ O_id);

            OrderDetailDataGridView2.Visible = false;
           



        }

        //step 2 取消訂購
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearall();
        }



        //清除所有欄位
        private void clearall()
        {
            O_id ="";
            TotalPrice = "";
            tbCustomerName.Text = " ";
            tbCustomerPhone.Text = " ";
            tbCustomerAddress.Text = " ";
            tbReferee1.Text = "";
            tbOrderNumber.Text = "";
            tbSubtotal.Text = "";
            tbTotalPrice.Text = "";
            chkDelivery.Checked = false;
            chkPay.Checked = false;
            panelStart.Visible = true;
            i_id = "";
        }



        //測試用
        private void showorderDetailDataGridView()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select top 100 *  from OrderDetail";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();   //會回傳查詢資料並存在data中

            if (reader.HasRows)   //hasrows 有的話才執行
            {//建立新元件讓資料顯示在gridview上 
                DataTable dt = new DataTable();
                dt.Load(reader);  //載入資料
                orderMasterDataGridView.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

       

        
        
        //顯示orderDetailDataGridVie
        
        private void showOrderDetailDataGridView2()
        {
            getorderid();
            //MessageBox.Show("show"+O_id);
            SqlConnection con3 = new SqlConnection(scsb.ToString());
            con3.Open();
            string strSQL3 = "select Item as '項次',ProductName as '品名',ProductPrice as '單價',Quantity as '數量', SubTotal as '小計' from OrderDetail where OrderId=@OrderId";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con3);
            cmd3.Parameters.AddWithValue("@OrderId", O_id);

            SqlDataReader reader = cmd3.ExecuteReader();   //會回傳查詢資料並存在data中

            if (reader.HasRows)   //hasrows 有的話才執行
            {//建立新元件讓資料顯示在gridview上 
                DataTable dt = new DataTable();
                dt.Load(reader);  //載入資料
                OrderDetailDataGridView2.DataSource = dt;
            }
            reader.Close();
            con3.Close();
            OrderDetailDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderDetailDataGridView2.Visible = true;
        }
   


        //點擊OrderDetailDataGridView2
        private void OrderDetailDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strQueryID = OrderDetailDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
           
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
           // string strSQL = "select Item as '項次',ProductName as '品名',ProductPrice as '單價',Quantity as '數量', SubTotal as '小計' from OrderDetail where OrderId=@OrderId";

            string strSQL = "select * from  OrderDetail where OrderId = " + O_id +" and Item = '" + strQueryID + "'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                i_id=string.Format("{0}", reader["Item"]);
                tbOrderNumber.Text = string.Format("{0}", reader["Quantity"]);
                tbSubtotal.Text = string.Format("{0}", reader["SubTotal"]);
            }
            reader.Close();
            con.Close();
            OrderDetailDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderDetailDataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        
        
        //更新產品細項
        private void buttonUpdataItem_Click(object sender, EventArgs e)
        {
            Subtotals();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "update OrderDetail set Quantity=@NewQuantity, SubTotal =@NewSubTotal  where OrderId = " + O_id + "and Item = '" + i_id + "'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewQuantity", tbOrderNumber.Text);            
            //gettotalprice();
            cmd.Parameters.AddWithValue("@NewSubTotal", tbSubtotal.Text);
            //cmd.Parameters.AddWithValue("@NewProductPrice", price);
            //cmd.Parameters.AddWithValue("@NewProductName", p_name);

            int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
            con.Close();
            MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));
            gettotalprice();
            showOrderDetailDataGridView2();
            i_id = "";

            
        }


        //刪除產品細項
        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "delete from OrderDetail where OrderId = " + O_id + " and Item = '" + i_id + "'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            
            int rows = cmd.ExecuteNonQuery();    
            con.Close();
            tbOrderNumber.Text = "";
            tbSubtotal.Text = "";
         
            gettotalprice(); 
            MessageBox.Show(string.Format("資料刪除完畢,共影響{0}列資料", rows));
            showOrderDetailDataGridView2();
            i_id = "";
        }
    }
    
}




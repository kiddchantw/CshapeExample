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
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb; //儲存資料庫連繫字串的物件

        //tbOrderIdInsert.Text = "";
        string i_id2 = "";
        //string O_id2 = string.Format((tbOrderIdInsert.text));

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.SingleDetail' 資料表。您可以視需要進行移動或移除。
            this.singleDetailTableAdapter1.Fill(this.orderSystem1DataSet2.SingleDetail);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.OrderMaster' 資料表。您可以視需要進行移動或移除。
            this.orderMasterTableAdapter.Fill(this.orderSystem1DataSet2.OrderMaster);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.Employee' 資料表。您可以視需要進行移動或移除。
            this.employeeTableAdapter1.Fill(this.orderSystem1DataSet2.Employee);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter1.Fill(this.orderSystem1DataSet2.Products);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet2.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter1.Fill(this.orderSystem1DataSet2.Customers);
            // TODO: 這行程式碼會將資料載入 'orderSystem1DataSet1.SingleDetail' 資料表。您可以視需要進行移動或移除。

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"(localdb)\DeptLocalDB";
            scsb.InitialCatalog = "OrderSystem1";
            scsb.IntegratedSecurity = true;

            showDataGridViewCustomers2();
            showDataGridViewProducts();
            showdataGridViewProducts2();
       
            gettotalsum();//營業額計算
            topproduct(); //熱銷商品
            mvp();//熟客排行
            Unsalableproduct();//滯銷商品


        }






        //顯示CustomersDataGridView
        private void showDataGridViewCustomers2()
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
                dataGridViewCustomers2.DataSource = dt;
            }
            reader.Close();
            con.Close();
            dataGridViewCustomers2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //自動調整欄位
            dataGridViewCustomers2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //點選整欄變色
            dataGridViewCustomers2.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        
        //顧客資料點擊同步顯示
        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //   MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()); //找出使用者點擊事件  

            string strQueryID = dataGridViewCustomers2.Rows[e.RowIndex].Cells[0].Value.ToString();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //string strSQL = "select top 100 * from  persons where id='" + strQueryID + "'";  
            string strSQL = "select * from  Customers where CustomerId = '" + strQueryID + "'";   //合成SQL字串
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tbCustomerName2.Text = string.Format("{0}", reader["CustomerName"]);
                tbCustomerPhone2.Text = string.Format("{0}", reader["CustomerPhone"]);
                tbCustomerAddress2.Text = string.Format("{0}", reader["CustomerAddress"]);
                tbReferee.Text = string.Format("{0}", reader["Referee"]);
            }
            reader.Close();
            con.Close();
            
        }

        



        //顯示ProductsDataGridView
        private void showDataGridViewProducts()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select top 100 * from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();   //會回傳查詢資料並存在data中

            if (reader.HasRows)   //hasrows 有的話才執行
            {//建立新元件讓資料顯示在gridview上 
                DataTable dt = new DataTable();
                dt.Load(reader);  //載入資料
                dataGridViewProducts.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void showdataGridViewProducts2()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select ProductId as '編號', ProductName as '品名',ProductPrice as'單價',ProductDetail as'明細'  from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();   //會回傳查詢資料並存在data中

            if (reader.HasRows)   //hasrows 有的話才執行
            {//建立新元件讓資料顯示在gridview上 
                DataTable dt = new DataTable();
                dt.Load(reader);  //載入資料
                dataGridViewProducts2.DataSource = dt;
            }
            reader.Close();
            con.Close();
            dataGridViewProducts2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //點選整欄變色
            dataGridViewProducts2.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        
       //產品資料點擊同步顯示
        private void dataGridViewProducts2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strQueryID2 = dataGridViewProducts2.Rows[e.RowIndex].Cells[0].Value.ToString();

            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();
            //string strSQL = "select top 100 * from  persons where id='" + strQueryID + "'";  
            string strSQL = "select ProductId as '編號', ProductName as '品名',ProductPrice as'單價',ProductDetail as'明細' from  Products where ProductId = '" + strQueryID2 + "'";   
            SqlCommand cmd = new SqlCommand(strSQL, con2);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tbProductName.Text = string.Format("{0}", reader["ProductName"]);
                tbProductPrice.Text = string.Format("{0}", reader["ProductPrice"]);
                tbProductDetail.Text = string.Format("{0}", reader["ProductDetail"]);

            }
            reader.Close();
            con2.Close();
        }




        //離開form2
        private void btbCloseForm2_Click(object sender, EventArgs e)
        {
            Close();
        }



        //分頁2
        //顧客資料查詢更新新增刪除
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (tbCustomerName2.Text.Length > 0)  //用姓名來搜尋
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                String strSQL = "select top 100 * from Customers where CustomerName=@SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tbCustomerName2.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbCustomerName2.Text = string.Format("{0}", reader["CustomerName"]);
                    tbCustomerPhone2.Text = string.Format("{0}", reader["CustomerPhone"]);
                    tbCustomerAddress2.Text = string.Format("{0}", reader["CustomerAddress"]);
                    tbReferee.Text = string.Format("{0}", reader["Referee"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    tbCustomerName2.Text = "";
                    tbCustomerPhone2.Text = "";
                    tbCustomerAddress2.Text = "";
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋");
            }
            showDataGridViewCustomers2();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (tbCustomerName2.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update Customers set CustomerPhone=@NewCustomerPhone, CustomerAddress=@NewCustomerAddress,Referee=@NewReferee where CustomerName=@SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tbCustomerName2.Text);
                cmd.Parameters.AddWithValue("@NewCustomerPhone", tbCustomerPhone2.Text);
                cmd.Parameters.AddWithValue("@NewCustomerAddress", tbCustomerAddress2.Text);
                cmd.Parameters.AddWithValue("@NewReferee", tbReferee.Text);

                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));

            }
            else {
                MessageBox.Show("請輸入姓名搜尋");
            }
            showDataGridViewCustomers2();
        }

        private void btnCustomerInsert_Click(object sender, EventArgs e)
        {
            if (tbCustomerName2.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Customers values(" + "@NewName,@NewCustomerPhone,@NewCustomerAddress,@NewReferee)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", tbCustomerName2.Text);
                cmd.Parameters.AddWithValue("@NewCustomerPhone", tbCustomerPhone2.Text);
                cmd.Parameters.AddWithValue("@NewCustomerAddress", tbCustomerAddress2.Text);
                cmd.Parameters.AddWithValue("@NewReferee", tbReferee.Text);

                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
            }
            else {
                MessageBox.Show("請輸入姓名搜尋");
            }
            showDataGridViewCustomers2();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (tbCustomerName2.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from Customers where CustomerName=@OldName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@OldName", tbCustomerName2.Text);
                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));
            }
            else {
                MessageBox.Show("請輸入姓名搜尋");
     
            }
            showDataGridViewCustomers2();
        }




        //分頁3
        //產品資料查詢更新新增刪除
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text.Length > 0)  //用產品名稱來搜尋
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                String strSQL = "select top 100 * from Products where ProductName=@SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tbProductName.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbProductName.Text = string.Format("{0}", reader["ProductName"]);
                    tbProductPrice.Text = string.Format("{0}", reader["ProductPrice"]);
                    tbProductDetail.Text = string.Format("{0}", reader["ProductDetail"]);
                }
                else
                {
                    MessageBox.Show("請輸入產品名稱搜尋");
                    tbProductName.Text = "";
                    tbProductPrice.Text = "";
                    tbProductDetail.Text = "";
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入產品名稱搜尋");
            }
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update Products set ProductPrice=@NewProductPrice, ProductDetail=@NewProductDetail where ProductName=@SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tbProductName.Text);
                cmd.Parameters.AddWithValue("@NewProductPrice", tbProductPrice.Text);
                cmd.Parameters.AddWithValue("@NewProductDetail", tbProductDetail.Text);

                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));

            }
            else {
                MessageBox.Show("請輸入產品名稱");
            }
            showDataGridViewProducts();
            showdataGridViewProducts2();
        }

        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Products values(" + "@NewProductName,@NewProductPrice,@NewProductDetail)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewProductName", tbProductName.Text);
                cmd.Parameters.AddWithValue("@NewProductPrice", tbProductPrice.Text);
                cmd.Parameters.AddWithValue("@NewProductDetail", tbProductDetail.Text);

                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
            }
            else {
                MessageBox.Show("請輸入產品名稱");
            }
            showDataGridViewProducts();
            showdataGridViewProducts2();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from Products where ProductName=@OldName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@OldName", tbProductName.Text);
                int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));
            }
            else {
                MessageBox.Show("請輸入產品名稱");
            }
            showDataGridViewProducts();
            showdataGridViewProducts2();

        }




        //計算營業額
        private void gettotalsum()
        {
            //MessageBox.Show("計算訂單總價來源O_id"+O_id);

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //先取得orderId
            string strSQL = "select sum(SubTotal) as sumtt from OrderDetail";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            //.Parameters.AddWithValue("@SearchOrderId", O_id);

            // cmd.Parameters.AddWithValue("@TotalPrice", Total);
            // MessageBox.Show("計算訂單總價共", Total.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tbsum.Text = string.Format("{0}", reader["sumtt"]);
            }
            else
            {
                MessageBox.Show("no營業額");
            }
        }

        //熱銷商品
        private void topproduct()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //先取得orderId
            string strSQL = "select ProductName, ProductId, sum(Quantity) as sumqq from OrderDetail group by ProductName,ProductId order by sum(Quantity) desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbltopproductname.Text = "-->" + string.Format("{0}", reader["ProductName"]) + "<--";
                lbltopproductsum.Text = "[銷售數量： " + string.Format("{0}", reader["sumqq"]) + "]";
            }
            else
            {
                MessageBox.Show("no熱銷商品");
            }
        }
       
        
        //滯銷商品
        private void Unsalableproduct()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //先取得orderId
            string strSQL = "select ProductName, ProductId, sum(Quantity) as sumqq from OrderDetail group by ProductName,ProductId order by sum(Quantity) asc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblUnsalablename.Text = string.Format("{0}", reader["ProductName"]) + "-->";
                lblUnsalablesum.Text = "[銷售數量： " + string.Format("{0}", reader["sumqq"]) + "]";
            }
            else
            {
                MessageBox.Show("no熱銷商品");
            }


        }

        //熟客排行
        private void mvp()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select top 1 om.CustomerId, c.CustomerName as ccname, count(*) as 來店數 ,sum(om.TotalPrice) as 消費額 from OrderMaster om inner join Customers c on om.CustomerId = c.CustomerId group by om.CustomerId,c.CustomerName order by om.CustomerId ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblMvp.Text = string.Format("{0}", reader["ccname"]);
                lblMvptime.Text = "*來店次數：" + string.Format("{0}", reader["來店數"]);
                lblMvpsum.Text = "*消費金額 " + string.Format("{0}", reader["消費額"]) +"元";
            }
            else
            {
                MessageBox.Show("no熟客");
            }


        }






        //分頁1
        //搜尋訂單  
        private void buttonSearchOrderDetail_Click(object sender, EventArgs e)
        {
            dataGridViewOrderMaster2.Visible = true;
            dataGridVieworderdetail2.Visible = false;
            if (tbOrderIdInsert.TextLength > 0 )//用orderid搜尋
            {
                if(tbCustomerName3.TextLength > 0 || tbCustomerPhone3.TextLength > 0)
                    {
                    MessageBox.Show("請先點選重新查詢按鍵");
                }else{
                    showdataGridViewOrderMaster2(); //orderid顯示訂單主狀態
                    showdataGridVieworderdetail2(); //orderid顯示訂單明細
                }
            }
            else if (tbCustomerName3.TextLength > 0 ) //用姓名找customerid再找 om上有幾筆資料並顯示最新的
            {
                if(tbOrderIdInsert.TextLength > 0 || tbCustomerPhone3.TextLength > 0)
                {
                    MessageBox.Show("請先點選重新查詢按鍵");
                }
                else
                {
                 searchCname();
                }
            }
            else
            {
                showOrderhandle();//用orderhanding t f 查詢
            }
           
            

        }

 
        /*
        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //取得目前滑鼠點選的CELL值
           tbOrderIdInsert.Text = dataGridViewOrderMaster2.CurrentCell.Value.ToString();
            //取得目前滑鼠點選的ROW值
            tbOrderIdInsert.Text = dataGridViewOrderMaster2.CurrentRow.Cells[0].Value.ToString();
        }*/




        //orderid搜尋顯示訂單明細
        private void showdataGridVieworderdetail2()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            String strSQL = "select Item as'項目' ,ProductName as '品名',ProductPrice as'單價' ,Quantity as '數量',SubTotal as '小計' from OrderDetail where OrderId =@SearchId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("SearchId", tbOrderIdInsert.Text);
            //MessageBox.Show("1." + tbOrderIdInsert.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            /*if (reader.Read())
            {
                MessageBox.Show("2." + tbOrderIdInsert.Text);
                // tbTotalPrice.Text = string.Format("{0}", reader["sumtt"]);
            }
            else
            {
                MessageBox.Show("no");
            }
            */
            /*SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from SingleDetail  where OrderId =@SearchId" ;
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("SearchId", tbOrderIdInsert.Text);
            SqlDataReader reader = cmd.ExecuteReader();   //會回傳查詢資料並存在data中

            */
            if (reader.HasRows)   //hasrows 有的話才執行
            {//建立新元件讓資料顯示在gridview上 
                DataTable dt = new DataTable();
                dt.Load(reader);  //載入資料
                dataGridVieworderdetail2.DataSource = dt;
            }
            reader.Close();
            con.Close();

            //先定義一個DataGridViewCellStyle物件名為Dvcellstyle
            //    DataGridViewCellStyle Dvcellstyle = new DataGridViewCellStyle();
            //  Dvcellstyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridVieworderdetail2.Visible = true;
            dataGridVieworderdetail2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            



        }

        //orderid搜尋顯示訂單主檔
        private void showdataGridViewOrderMaster2()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            String strSQL = "select OrderId as '編號',TotalPrice as '總價', Pay as '已結清',Pickup as'宅配',OrderHandling as '處理完畢' from OrderMaster where OrderId ='" + tbOrderIdInsert.Text + "' order by OrderId asc";   //@SearchId
            SqlCommand cmd = new SqlCommand(strSQL, con);
          
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewOrderMaster2.DataSource = dt;
            }
            reader.Close();
            con.Close();
            dataGridViewOrderMaster2.Visible = true;
            dataGridViewOrderMaster2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            //dataGridViewOrderMaster2.AutoSizeColumnsMode= DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dataGridViewOrderMaster2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dataGridViewOrderMaster2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;//DisplayedCells;

            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();
            String strSQL2 = "select c.CustomerName as CName, c.CustomerPhone as CPhone  from Customers c inner join  OrderMaster o  on c.CustomerId =o.CustomerId where o.OrderId ='" + tbOrderIdInsert.Text + "'" ;
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
         
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                tbCustomerName3.Text = string.Format("{0}", reader2["CName"]);
                tbCustomerPhone3.Text = string.Format("{0}", reader2["CPhone"]);
            }
            else {
                MessageBox.Show("no顯示訂單主檔");
            }



        }


        //用姓名找customerid Orderid
        private void  searchCname(){
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            String strSQL = "select o.OrderId as 編號,o.OrderDate as 日期,o.Pickup as 宅配 ,o.TotalPrice as 總價 from OrderMaster as o inner join Customers as c on o.CustomerId = c.CustomerId where o.CustomerId in (select c.CustomerId from Customers where c.CustomerName =@searchname1) order by o.OrderDate desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@searchname1", tbCustomerName3.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewOrderMaster2.DataSource = dt;
            }
            reader.Close();
            con.Close();
            // dataGridViewOrderMaster2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridViewOrderMaster2.Visible = ;
            dataGridVieworderdetail2.Visible = true;
        }





        //用orderhanding t f 查詢
        private void showOrderhandle()
       {
            String strSQL = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //if ((bool)chkOrderhandling.Checked == false)
            if ((bool)chkOrderhandling.Checked == true)
            {
                strSQL = "select OrderId as 編號, TotalPrice as 總價, Pickup as 宅配, OrderDate as 訂購日期, OrderHandling as 已處理 from OrderMaster where OrderHandling = 1 order by OrderId asc";//可加入PickupData as 處理日期, Employee as 處理員工   
            }
            else {

                strSQL = "select OrderId as 編號, TotalPrice as 總價, Pickup as 宅配, OrderDate as 訂購日期, OrderHandling as 已處理 from OrderMaster where ( OrderHandling is null ) or ( OrderHandling = 0 ) order by OrderId asc";
            }
            
                        
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@chk", (bool)chkOrderhandling.Checked);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewOrderMaster2.DataSource = dt;
            }
            reader.Close();
            con.Close();

            //dataGridViewOrderMaster2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrderMaster2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderMaster2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }


        //更新訂單  只用orderhanding
        private void btnUpdata2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "update OrderMaster set OrderHandling = @OrderHandling, PickupData = @PickupDate, Pay =@Pay where OrderId = '" + tbOrderIdInsert.Text +"'" ;
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@OrderHandling ", (bool)chkOrderhandling.Checked);
            cmd.Parameters.AddWithValue("@PickupDate ", (DateTime)dtpOrderHandling.Value);
            cmd.Parameters.AddWithValue("@Pay ", (bool)chkPay2.Checked);
            int rows = cmd.ExecuteNonQuery();    //無回傳值,直接show資料筆數
            con.Close();
            MessageBox.Show(string.Format("資料更新完畢,共影響{0}列資料", rows));
            refreshtotalprice();
            showdataGridViewOrderMaster2();
          
        }

        //重新查詢
        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            tbOrderIdInsert.Text = "";
            tbCustomerPhone3.Text = "";
            tbCustomerName3.Text = "";
            chkOrderhandling.Checked = false;
            chkPay2.Checked = false;
            dtpOrderHandling.Value = DateTime.Now;
            dataGridViewOrderMaster2.Visible = false;
            dataGridVieworderdetail2.Visible = false;
        }




        //點選orderdetail
        private void dataGridVieworderdetail2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strQueryID = dataGridVieworderdetail2.Rows[e.RowIndex].Cells[0].Value.ToString();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from  OrderDetail where OrderId = '" + tbOrderIdInsert.Text+"'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               i_id2 = string.Format("{0}", reader["Item"]);
            }
            reader.Close();
            con.Close();
            //dataGridVieworderdetail2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVieworderdetail2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVieworderdetail2.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        //點選ordermaster
        private void dataGridViewOrderMaster2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strQueryID = dataGridViewOrderMaster2.Rows[e.RowIndex].Cells[0].Value.ToString();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select OrderId as 編號, TotalPrice as 總價, Pay as 已結清, Pickup as 宅配,OrderHandling  as 已處理,OrderDate as 訂購日期  from  OrderMaster where OrderId = '" + strQueryID + "' order by OrderId desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbOrderIdInsert.Text= string.Format("{0}", reader["編號"]);

            }
            reader.Close();
            con.Close();
            //dataGridViewOrderMaster2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrderMaster2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderMaster2.DefaultCellStyle.SelectionBackColor = Color.Chocolate;

        }


        string TotalPrice2;//總價重算

        //刪除 更新後重算總價()
        private void refreshtotalprice()
        {
            
            SqlConnection con3 = new SqlConnection(scsb.ToString());
            con3.Open();
            string strSQL3 = "select sum(SubTotal) as sumtt from OrderDetail where OrderId ='" + tbOrderIdInsert.Text + "'";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con3);

            SqlDataReader reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                TotalPrice2 = string.Format("{0}", reader["sumtt"]);
            }
            else
            {
                MessageBox.Show("no重算總價錯誤");
            }



            //更新總價資料回到ordermaster
            SqlConnection con4 = new SqlConnection(scsb.ToString());
            con4.Open();
            string strSQL4 = "update OrderMaster set  TotalPrice= @TotalPrice where OrderId ='" + tbOrderIdInsert.Text + "'";
            SqlCommand cmd4 = new SqlCommand(strSQL4, con4);
            cmd4.Parameters.AddWithValue("@TotalPrice", TotalPrice2);
            ///cmd.Parameters.AddWithValue("@OrderHandling ", (bool)chkOrderhandling.Checked);

            int rows4 = cmd4.ExecuteNonQuery();    //無回傳值,直接show資料筆數
            con4.Close();
           // MessageBox.Show(string.Format("om資料更新完畢,共影響{0}列資料", rows4));
        }


        //刪除
        private void btnOrderDelete_Click(object sender, EventArgs e)
        {

            if (i_id2.Length > 0 && tbOrderIdInsert.TextLength > 0)
            {
                SqlConnection con1 = new SqlConnection(scsb.ToString());
                con1.Open();
                string strSQL1 = "delete from OrderDetail where OrderId = " + tbOrderIdInsert.Text + " and Item = '" + i_id2 + "'";
                SqlCommand cmd = new SqlCommand(strSQL1, con1);

                int rows1 = cmd.ExecuteNonQuery();
                con1.Close();

                MessageBox.Show(string.Format("訂購單刪除完畢,共影響{0}列資料", rows1));
            }
            else if ( tbOrderIdInsert.TextLength > 0) // && i_id2 == null)
            {
                SqlConnection con2 = new SqlConnection(scsb.ToString());
                con2.Open();
                string strSQL2 = "delete from OrderMaster where OrderId ='" + tbOrderIdInsert.Text + "'";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con2);

                int rows2 = cmd2.ExecuteNonQuery();
                con2.Close();

                MessageBox.Show(string.Format("明細資料刪除完畢,共影響{0}列資料", rows2));
            }
            else { MessageBox.Show("No 刪除錯誤"); }

            refreshtotalprice();
            gettotalsum();//營業額要重新計算

            

            i_id2 = "";
            showdataGridViewOrderMaster2();
            showdataGridVieworderdetail2();
            TotalPrice2 = "";
            
        }


        //所有歷史訂單查詢
        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            dataGridViewOrderMaster2.Visible = true;
            //dataGridVieworderdetail2.Visible = true;
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select OrderId as 編號, TotalPrice as 總價, Pay as 已結清 , Pickup as 宅配, OrderDate as 訂購日期, OrderHandling as 已處理, PickupData as 處理日期 from OrderMaster order by OrderId desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewOrderMaster2.DataSource = dt;
            }
            reader.Close();
            con.Close();
           // dataGridViewOrderMaster2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrderMaster2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderMaster2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void dataGridViewOrderMaster2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOrderMaster2.Visible = true;
            dataGridVieworderdetail2.Visible = true;
            if (tbOrderIdInsert.TextLength > 0)//用orderid搜尋
            {
                if (tbCustomerName3.TextLength > 0 || tbCustomerPhone3.TextLength > 0)
                {
                    MessageBox.Show("請先點選重新查詢按鍵");
                }
                else {
                    showdataGridViewOrderMaster2(); //orderid顯示訂單主狀態
                    showdataGridVieworderdetail2(); //orderid顯示訂單明細
                }
            }
            else
            {
                MessageBox.Show("請先點選重新查詢按鍵");
            }
        }



    }


}


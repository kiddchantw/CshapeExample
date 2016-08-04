namespace OrderV2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer1 = new System.Windows.Forms.Button();
            this.tbReferee1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSystem1DataSet = new OrderV2.OrderSystem1DataSet();
            this.customersTableAdapter = new OrderV2.OrderSystem1DataSetTableAdapters.CustomersTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPay = new System.Windows.Forms.CheckBox();
            this.OrderDetailDataGridView2 = new System.Windows.Forms.DataGridView();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonOrderClear = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonOrderDetailStart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.orderSystem1DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSystem1DataSet2 = new OrderV2.OrderSystem1DataSet2();
            this.buttonUpdataItem = new System.Windows.Forms.Button();
            this.singleDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.singleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSystem1DataSet1 = new OrderV2.OrderSystem1DataSet1();
            this.lblPrice = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new OrderV2.OrderSystem1DataSetTableAdapters.ProductsTableAdapter();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.btnCloseSystem = new System.Windows.Forms.Button();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailTableAdapter = new OrderV2.OrderSystem1DataSet1TableAdapters.OrderDetailTableAdapter();
            this.tableAdapterManager = new OrderV2.OrderSystem1DataSet1TableAdapters.TableAdapterManager();
            this.singleDetailTableAdapter = new OrderV2.OrderSystem1DataSet1TableAdapters.SingleDetailTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLoginId = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.dtpOrderTime1 = new System.Windows.Forms.DateTimePicker();
            this.tableAdapterManager1 = new OrderV2.OrderSystem1DataSetTableAdapters.TableAdapterManager();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new OrderV2.OrderSystem1DataSet2TableAdapters.CustomersTableAdapter();
            this.tableAdapterManager2 = new OrderV2.OrderSystem1DataSet2TableAdapters.TableAdapterManager();
            this.DataGridViewCustomer1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleDetailTableAdapter1 = new OrderV2.OrderSystem1DataSet2TableAdapters.SingleDetailTableAdapter();
            this.panelStart = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonStartOrder = new System.Windows.Forms.Button();
            this.lblCuerrentNow1 = new System.Windows.Forms.Label();
            this.orderMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderMasterTableAdapter = new OrderV2.OrderSystem1DataSet2TableAdapters.OrderMasterTableAdapter();
            this.orderMasterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailTableAdapter1 = new OrderV2.OrderSystem1DataSet2TableAdapters.OrderDetailTableAdapter();
            this.orderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsTableAdapter1 = new OrderV2.OrderSystem1DataSet2TableAdapters.ProductsTableAdapter();
            this.lblp_id = new System.Windows.Forms.Label();
            this.lblp_name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomer1)).BeginInit();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderMasterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnInsertCustomer);
            this.groupBox1.Controls.Add(this.btnUpdateCustomer);
            this.groupBox1.Controls.Add(this.btnSearchCustomer1);
            this.groupBox1.Controls.Add(this.tbReferee1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCustomerAddress);
            this.groupBox1.Controls.Add(this.tbCustomerPhone);
            this.groupBox1.Controls.Add(this.tbCustomerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 請輸入訂購者基本資料  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(242, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "*請用姓名或電話搜尋";
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.BackColor = System.Drawing.Color.LightCyan;
            this.btnInsertCustomer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertCustomer.Location = new System.Drawing.Point(350, 106);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(58, 34);
            this.btnInsertCustomer.TabIndex = 10;
            this.btnInsertCustomer.Text = "新增";
            this.btnInsertCustomer.UseVisualStyleBackColor = false;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.LightCyan;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(350, 66);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(58, 34);
            this.btnUpdateCustomer.TabIndex = 9;
            this.btnUpdateCustomer.Text = "更新";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnSearchCustomer1
            // 
            this.btnSearchCustomer1.BackColor = System.Drawing.Color.LightCyan;
            this.btnSearchCustomer1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchCustomer1.Location = new System.Drawing.Point(245, 66);
            this.btnSearchCustomer1.Name = "btnSearchCustomer1";
            this.btnSearchCustomer1.Size = new System.Drawing.Size(98, 74);
            this.btnSearchCustomer1.TabIndex = 8;
            this.btnSearchCustomer1.Text = "查詢";
            this.btnSearchCustomer1.UseVisualStyleBackColor = false;
            this.btnSearchCustomer1.Click += new System.EventHandler(this.btnSearchCustomer1_Click);
            // 
            // tbReferee1
            // 
            this.tbReferee1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbReferee1.Location = new System.Drawing.Point(305, 30);
            this.tbReferee1.Name = "tbReferee1";
            this.tbReferee1.Size = new System.Drawing.Size(118, 29);
            this.tbReferee1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(242, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "推薦人";
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCustomerAddress.Location = new System.Drawing.Point(71, 110);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(152, 29);
            this.tbCustomerAddress.TabIndex = 5;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCustomerPhone.Location = new System.Drawing.Point(71, 67);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(152, 29);
            this.tbCustomerPhone.TabIndex = 4;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCustomerName.Location = new System.Drawing.Point(71, 30);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(152, 29);
            this.tbCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "電話";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.orderSystem1DataSet;
            // 
            // orderSystem1DataSet
            // 
            this.orderSystem1DataSet.DataSetName = "OrderSystem1DataSet";
            this.orderSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPay);
            this.groupBox2.Controls.Add(this.OrderDetailDataGridView2);
            this.groupBox2.Controls.Add(this.chkDelivery);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.buttonOrderClear);
            this.groupBox2.Controls.Add(this.buttonDeleteItem);
            this.groupBox2.Controls.Add(this.buttonOrderDetailStart);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbTotalPrice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblDetail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbSubtotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbOrderNumber);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(6, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 3 請輸入訂購物品與數量";
            // 
            // chkPay
            // 
            this.chkPay.AutoSize = true;
            this.chkPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkPay.Location = new System.Drawing.Point(165, 275);
            this.chkPay.Name = "chkPay";
            this.chkPay.Size = new System.Drawing.Size(76, 24);
            this.chkPay.TabIndex = 33;
            this.chkPay.Text = "已付款";
            this.chkPay.UseVisualStyleBackColor = true;
            // 
            // OrderDetailDataGridView2
            // 
            this.OrderDetailDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailDataGridView2.Location = new System.Drawing.Point(17, 99);
            this.OrderDetailDataGridView2.Name = "OrderDetailDataGridView2";
            this.OrderDetailDataGridView2.RowTemplate.Height = 24;
            this.OrderDetailDataGridView2.Size = new System.Drawing.Size(414, 131);
            this.OrderDetailDataGridView2.TabIndex = 32;
            this.OrderDetailDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDetailDataGridView2_CellClick);
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Location = new System.Drawing.Point(33, 267);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(67, 28);
            this.chkDelivery.TabIndex = 31;
            this.chkDelivery.Text = "宅配";
            this.chkDelivery.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(27, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "取貨方式";
            // 
            // buttonOrderClear
            // 
            this.buttonOrderClear.BackColor = System.Drawing.Color.Azure;
            this.buttonOrderClear.Location = new System.Drawing.Point(358, 236);
            this.buttonOrderClear.Name = "buttonOrderClear";
            this.buttonOrderClear.Size = new System.Drawing.Size(73, 63);
            this.buttonOrderClear.TabIndex = 27;
            this.buttonOrderClear.Text = "訂購完畢";
            this.buttonOrderClear.UseVisualStyleBackColor = false;
            this.buttonOrderClear.Click += new System.EventHandler(this.buttonOrderClear_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Azure;
            this.buttonDeleteItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(300, 241);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(50, 55);
            this.buttonDeleteItem.TabIndex = 26;
            this.buttonDeleteItem.Text = "刪除選項";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonOrderDetailStart
            // 
            this.buttonOrderDetailStart.BackColor = System.Drawing.Color.Azure;
            this.buttonOrderDetailStart.Location = new System.Drawing.Point(358, 27);
            this.buttonOrderDetailStart.Name = "buttonOrderDetailStart";
            this.buttonOrderDetailStart.Size = new System.Drawing.Size(73, 62);
            this.buttonOrderDetailStart.TabIndex = 25;
            this.buttonOrderDetailStart.Text = "確認購買";
            this.buttonOrderDetailStart.UseVisualStyleBackColor = false;
            this.buttonOrderDetailStart.Click += new System.EventHandler(this.buttonOrderDetailStart_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "元";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbTotalPrice.Location = new System.Drawing.Point(164, 241);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(85, 29);
            this.tbTotalPrice.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(115, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "總計";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetail.ForeColor = System.Drawing.Color.Red;
            this.lblDetail.Location = new System.Drawing.Point(80, 32);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(48, 24);
            this.lblDetail.TabIndex = 21;
            this.lblDetail.Text = "說明";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "元";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSubtotal.Location = new System.Drawing.Point(272, 59);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(50, 29);
            this.tbSubtotal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "小計";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "產品";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbOrderNumber.Location = new System.Drawing.Point(178, 58);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(50, 29);
            this.tbOrderNumber.TabIndex = 11;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Azure;
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlus.Location = new System.Drawing.Point(230, 58);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(31, 31);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "＋";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Azure;
            this.btnMinus.Location = new System.Drawing.Point(142, 57);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(34, 31);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productsBindingSource3;
            this.comboBox1.DisplayMember = "ProductName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 32);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "ProductName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productsBindingSource3
            // 
            this.productsBindingSource3.DataMember = "Products";
            this.productsBindingSource3.DataSource = this.orderSystem1DataSet2BindingSource;
            // 
            // orderSystem1DataSet2BindingSource
            // 
            this.orderSystem1DataSet2BindingSource.DataSource = this.orderSystem1DataSet2;
            this.orderSystem1DataSet2BindingSource.Position = 0;
            // 
            // orderSystem1DataSet2
            // 
            this.orderSystem1DataSet2.DataSetName = "OrderSystem1DataSet2";
            this.orderSystem1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdataItem
            // 
            this.buttonUpdataItem.BackColor = System.Drawing.Color.Azure;
            this.buttonUpdataItem.Location = new System.Drawing.Point(595, 148);
            this.buttonUpdataItem.Name = "buttonUpdataItem";
            this.buttonUpdataItem.Size = new System.Drawing.Size(69, 29);
            this.buttonUpdataItem.TabIndex = 22;
            this.buttonUpdataItem.Text = "更新";
            this.buttonUpdataItem.UseVisualStyleBackColor = false;
            this.buttonUpdataItem.Click += new System.EventHandler(this.buttonUpdataItem_Click);
            // 
            // singleDetailBindingSource1
            // 
            this.singleDetailBindingSource1.DataMember = "SingleDetail";
            this.singleDetailBindingSource1.DataSource = this.orderSystem1DataSet2;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.orderSystem1DataSet2;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.orderSystem1DataSet;
            // 
            // singleDetailBindingSource
            // 
            this.singleDetailBindingSource.DataMember = "SingleDetail";
            this.singleDetailBindingSource.DataSource = this.orderSystem1DataSet1;
            // 
            // orderSystem1DataSet1
            // 
            this.orderSystem1DataSet1.DataSetName = "OrderSystem1DataSet1";
            this.orderSystem1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(896, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 12);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "label Price";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.orderSystem1DataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Azure;
            this.buttonLogin.Location = new System.Drawing.Point(297, 505);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(81, 22);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "管理登錄";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // btnCloseSystem
            // 
            this.btnCloseSystem.BackColor = System.Drawing.Color.Azure;
            this.btnCloseSystem.Location = new System.Drawing.Point(384, 506);
            this.btnCloseSystem.Name = "btnCloseSystem";
            this.btnCloseSystem.Size = new System.Drawing.Size(66, 20);
            this.btnCloseSystem.TabIndex = 13;
            this.btnCloseSystem.Text = "系統關閉";
            this.btnCloseSystem.UseVisualStyleBackColor = false;
            this.btnCloseSystem.Click += new System.EventHandler(this.btnCloseSystem_Click);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "OrderDetail";
            this.orderDetailBindingSource.DataSource = this.orderSystem1DataSet1;
            // 
            // orderDetailTableAdapter
            // 
            this.orderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderDetailTableAdapter = this.orderDetailTableAdapter;
            this.tableAdapterManager.OrderMasterTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OrderV2.OrderSystem1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // singleDetailTableAdapter
            // 
            this.singleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(12, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "登入";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(144, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "密碼";
            // 
            // tbLoginId
            // 
            this.tbLoginId.Location = new System.Drawing.Point(50, 502);
            this.tbLoginId.Name = "tbLoginId";
            this.tbLoginId.Size = new System.Drawing.Size(83, 22);
            this.tbLoginId.TabIndex = 23;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(182, 502);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(100, 22);
            this.tbpassword.TabIndex = 24;
            // 
            // dtpOrderTime1
            // 
            this.dtpOrderTime1.Location = new System.Drawing.Point(156, 11);
            this.dtpOrderTime1.Name = "dtpOrderTime1";
            this.dtpOrderTime1.Size = new System.Drawing.Size(115, 22);
            this.dtpOrderTime1.TabIndex = 25;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = OrderV2.OrderSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.orderSystem1DataSet2;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.CustomersTableAdapter = this.customersTableAdapter1;
            this.tableAdapterManager2.EmployeeTableAdapter = null;
            this.tableAdapterManager2.OrderDetailTableAdapter = null;
            this.tableAdapterManager2.OrderMasterTableAdapter = null;
            this.tableAdapterManager2.ProductsTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = OrderV2.OrderSystem1DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataGridViewCustomer1
            // 
            this.DataGridViewCustomer1.AutoGenerateColumns = false;
            this.DataGridViewCustomer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomer1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.DataGridViewCustomer1.DataSource = this.customersBindingSource1;
            this.DataGridViewCustomer1.Location = new System.Drawing.Point(608, 15);
            this.DataGridViewCustomer1.Name = "DataGridViewCustomer1";
            this.DataGridViewCustomer1.RowTemplate.Height = 24;
            this.DataGridViewCustomer1.Size = new System.Drawing.Size(373, 70);
            this.DataGridViewCustomer1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn6.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn7.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CustomerPhone";
            this.dataGridViewTextBoxColumn8.HeaderText = "CustomerPhone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CustomerAddress";
            this.dataGridViewTextBoxColumn9.HeaderText = "CustomerAddress";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Referee";
            this.dataGridViewTextBoxColumn10.HeaderText = "Referee";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // singleDetailTableAdapter1
            // 
            this.singleDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // panelStart
            // 
            this.panelStart.BackgroundImage = global::OrderV2.Properties.Resources.step2;
            this.panelStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelStart.Controls.Add(this.buttonCancel);
            this.panelStart.Controls.Add(this.label15);
            this.panelStart.Controls.Add(this.buttonStartOrder);
            this.panelStart.Controls.Add(this.dtpOrderTime1);
            this.panelStart.Location = new System.Drawing.Point(15, 185);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(426, 305);
            this.panelStart.TabIndex = 26;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Azure;
            this.buttonCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.Location = new System.Drawing.Point(139, 273);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 25);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "取消/重新訂購";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(17, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 27);
            this.label15.TabIndex = 26;
            this.label15.Text = "Step 2";
            // 
            // buttonStartOrder
            // 
            this.buttonStartOrder.BackColor = System.Drawing.Color.Azure;
            this.buttonStartOrder.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStartOrder.Location = new System.Drawing.Point(110, 119);
            this.buttonStartOrder.Name = "buttonStartOrder";
            this.buttonStartOrder.Size = new System.Drawing.Size(207, 64);
            this.buttonStartOrder.TabIndex = 0;
            this.buttonStartOrder.Text = "開始訂購";
            this.buttonStartOrder.UseVisualStyleBackColor = false;
            this.buttonStartOrder.Click += new System.EventHandler(this.buttonStartOrder_Click);
            // 
            // lblCuerrentNow1
            // 
            this.lblCuerrentNow1.AutoSize = true;
            this.lblCuerrentNow1.Location = new System.Drawing.Point(864, 12);
            this.lblCuerrentNow1.Name = "lblCuerrentNow1";
            this.lblCuerrentNow1.Size = new System.Drawing.Size(86, 12);
            this.lblCuerrentNow1.TabIndex = 1;
            this.lblCuerrentNow1.Text = "lblCuerrentNow1";
            // 
            // orderMasterBindingSource
            // 
            this.orderMasterBindingSource.DataMember = "OrderMaster";
            this.orderMasterBindingSource.DataSource = this.orderSystem1DataSet2;
            // 
            // orderMasterTableAdapter
            // 
            this.orderMasterTableAdapter.ClearBeforeFill = true;
            // 
            // orderMasterDataGridView
            // 
            this.orderMasterDataGridView.AutoGenerateColumns = false;
            this.orderMasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderMasterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.orderMasterDataGridView.DataSource = this.orderMasterBindingSource;
            this.orderMasterDataGridView.Location = new System.Drawing.Point(658, 48);
            this.orderMasterDataGridView.Name = "orderMasterDataGridView";
            this.orderMasterDataGridView.RowTemplate.Height = 24;
            this.orderMasterDataGridView.Size = new System.Drawing.Size(413, 86);
            this.orderMasterDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn11.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn12.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn14.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Pickup";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Pickup";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "OrderHandling";
            this.dataGridViewCheckBoxColumn2.HeaderText = "OrderHandling";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PickupData";
            this.dataGridViewTextBoxColumn15.HeaderText = "PickupData";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn16.HeaderText = "TotalPrice";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // orderDetailBindingSource1
            // 
            this.orderDetailBindingSource1.DataMember = "OrderDetail";
            this.orderDetailBindingSource1.DataSource = this.orderSystem1DataSet2;
            // 
            // orderDetailTableAdapter1
            // 
            this.orderDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // orderDetailDataGridView
            // 
            this.orderDetailDataGridView.AutoGenerateColumns = false;
            this.orderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.orderDetailDataGridView.DataSource = this.orderDetailBindingSource1;
            this.orderDetailDataGridView.Location = new System.Drawing.Point(706, 97);
            this.orderDetailDataGridView.Name = "orderDetailDataGridView";
            this.orderDetailDataGridView.RowTemplate.Height = 24;
            this.orderDetailDataGridView.Size = new System.Drawing.Size(453, 77);
            this.orderDetailDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn17.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn18.HeaderText = "Item";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn19.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn20.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ProductPrice";
            this.dataGridViewTextBoxColumn21.HeaderText = "ProductPrice";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn22.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn23.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // lblp_id
            // 
            this.lblp_id.AutoSize = true;
            this.lblp_id.Location = new System.Drawing.Point(904, 88);
            this.lblp_id.Name = "lblp_id";
            this.lblp_id.Size = new System.Drawing.Size(38, 12);
            this.lblp_id.TabIndex = 27;
            this.lblp_id.Text = "lblp_id";
            // 
            // lblp_name
            // 
            this.lblp_name.AutoSize = true;
            this.lblp_name.Location = new System.Drawing.Point(896, 114);
            this.lblp_name.Name = "lblp_name";
            this.lblp_name.Size = new System.Drawing.Size(54, 12);
            this.lblp_name.TabIndex = 28;
            this.lblp_name.Text = "lblp_name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(462, 535);
            this.Controls.Add(this.lblp_name);
            this.Controls.Add(this.lblp_id);
            this.Controls.Add(this.orderMasterDataGridView);
            this.Controls.Add(this.orderDetailDataGridView);
            this.Controls.Add(this.lblCuerrentNow1);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.buttonUpdataItem);
            this.Controls.Add(this.DataGridViewCustomer1);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbLoginId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCloseSystem);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "顧客購買介面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystem1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomer1)).EndInit();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderMasterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnSearchCustomer1;
        private System.Windows.Forms.TextBox tbReferee1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private OrderSystem1DataSet orderSystem1DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private OrderSystem1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private OrderSystem1DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.Button btnCloseSystem;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label label9;
        private OrderSystem1DataSet1 orderSystem1DataSet1;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private OrderSystem1DataSet1TableAdapters.OrderDetailTableAdapter orderDetailTableAdapter;
        private OrderSystem1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource singleDetailBindingSource;
        private OrderSystem1DataSet1TableAdapters.SingleDetailTableAdapter singleDetailTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLoginId;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button buttonOrderClear;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonUpdataItem;
        private System.Windows.Forms.Button buttonOrderDetailStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpOrderTime1;
        private System.Windows.Forms.Label label14;
        private OrderSystem1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private OrderSystem1DataSet2 orderSystem1DataSet2;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private OrderSystem1DataSet2TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private OrderSystem1DataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView DataGridViewCustomer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource singleDetailBindingSource1;
        private OrderSystem1DataSet2TableAdapters.SingleDetailTableAdapter singleDetailTableAdapter1;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Button buttonStartOrder;
        private System.Windows.Forms.Label lblCuerrentNow1;
        private System.Windows.Forms.BindingSource orderMasterBindingSource;
        private OrderSystem1DataSet2TableAdapters.OrderMasterTableAdapter orderMasterTableAdapter;
        private System.Windows.Forms.DataGridView orderMasterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.BindingSource orderDetailBindingSource1;
        private OrderSystem1DataSet2TableAdapters.OrderDetailTableAdapter orderDetailTableAdapter1;
        private System.Windows.Forms.DataGridView orderDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private OrderSystem1DataSet2TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Label lblp_id;
        private System.Windows.Forms.Label lblp_name;
        private System.Windows.Forms.BindingSource productsBindingSource3;
        private System.Windows.Forms.BindingSource orderSystem1DataSet2BindingSource;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView OrderDetailDataGridView2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox chkPay;
    }
}


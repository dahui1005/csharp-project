namespace WinFormProjectBook
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tables = new System.Windows.Forms.GroupBox();
            this.rbOrders = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCustId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.tbDateMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDateMin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbBookId2 = new System.Windows.Forms.TextBox();
            this.tbPrice2 = new System.Windows.Forms.TextBox();
            this.tbCustId2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.tbOdersId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tables.SuspendLayout();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbCustomer.SuspendLayout();
            this.gbOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tables
            // 
            this.tables.Controls.Add(this.rbOrders);
            this.tables.Controls.Add(this.rbCustomer);
            this.tables.Controls.Add(this.rbBook);
            this.tables.Location = new System.Drawing.Point(18, 17);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(762, 59);
            this.tables.TabIndex = 0;
            this.tables.TabStop = false;
            this.tables.Text = "tables";
            // 
            // rbOrders
            // 
            this.rbOrders.AutoSize = true;
            this.rbOrders.Location = new System.Drawing.Point(627, 24);
            this.rbOrders.Name = "rbOrders";
            this.rbOrders.Size = new System.Drawing.Size(72, 19);
            this.rbOrders.TabIndex = 2;
            this.rbOrders.TabStop = true;
            this.rbOrders.Text = "Orders";
            this.rbOrders.UseVisualStyleBackColor = true;
            this.rbOrders.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(324, 24);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(90, 19);
            this.rbCustomer.TabIndex = 1;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(24, 24);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(63, 19);
            this.rbBook.TabIndex = 0;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(665, 306);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 91);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.cbPublisher);
            this.gbBook.Controls.Add(this.tbPrice);
            this.gbBook.Controls.Add(this.label4);
            this.gbBook.Controls.Add(this.label3);
            this.gbBook.Controls.Add(this.tbBookName);
            this.gbBook.Controls.Add(this.label2);
            this.gbBook.Controls.Add(this.tbBookId);
            this.gbBook.Controls.Add(this.label1);
            this.gbBook.Location = new System.Drawing.Point(18, 107);
            this.gbBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBook.Name = "gbBook";
            this.gbBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBook.Size = new System.Drawing.Size(627, 107);
            this.gbBook.TabIndex = 8;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "검색 조건";
            // 
            // cbPublisher
            // 
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(390, 26);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(199, 23);
            this.cbPublisher.TabIndex = 15;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(390, 61);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(199, 25);
            this.tbPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(332, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "가격 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(332, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "출판사 :";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(91, 61);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(178, 25);
            this.tbBookName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "책이름 :";
            // 
            // tbBookId
            // 
            this.tbBookId.Location = new System.Drawing.Point(91, 25);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(178, 25);
            this.tbBookId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "책보노 :";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(665, 93);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 95);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(665, 196);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 102);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(627, 383);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.tbPhone);
            this.gbCustomer.Controls.Add(this.label7);
            this.gbCustomer.Controls.Add(this.tbAddress);
            this.gbCustomer.Controls.Add(this.label8);
            this.gbCustomer.Controls.Add(this.tbName);
            this.gbCustomer.Controls.Add(this.label9);
            this.gbCustomer.Controls.Add(this.tbCustId);
            this.gbCustomer.Controls.Add(this.label10);
            this.gbCustomer.Location = new System.Drawing.Point(18, 107);
            this.gbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCustomer.Size = new System.Drawing.Size(627, 107);
            this.gbCustomer.TabIndex = 10;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "검색 조건";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(407, 61);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(182, 25);
            this.tbPhone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(332, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "폰보노 :";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(407, 25);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(182, 25);
            this.tbAddress.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(332, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = " 주  소 :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(108, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 25);
            this.tbName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(16, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "고객이름 :";
            // 
            // tbCustId
            // 
            this.tbCustId.Location = new System.Drawing.Point(108, 25);
            this.tbCustId.Name = "tbCustId";
            this.tbCustId.Size = new System.Drawing.Size(178, 25);
            this.tbCustId.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(16, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "고객보노 :";
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.tbDateMax);
            this.gbOrders.Controls.Add(this.label6);
            this.gbOrders.Controls.Add(this.tbDateMin);
            this.gbOrders.Controls.Add(this.label15);
            this.gbOrders.Controls.Add(this.tbBookId2);
            this.gbOrders.Controls.Add(this.tbPrice2);
            this.gbOrders.Controls.Add(this.tbCustId2);
            this.gbOrders.Controls.Add(this.label14);
            this.gbOrders.Controls.Add(this.label12);
            this.gbOrders.Controls.Add(this.label11);
            this.gbOrders.Controls.Add(this.tbOrderId);
            this.gbOrders.Controls.Add(this.tbOdersId);
            this.gbOrders.Location = new System.Drawing.Point(18, 107);
            this.gbOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOrders.Size = new System.Drawing.Size(627, 107);
            this.gbOrders.TabIndex = 11;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "검색 조건";
            // 
            // tbDateMax
            // 
            this.tbDateMax.Location = new System.Drawing.Point(498, 61);
            this.tbDateMax.Name = "tbDateMax";
            this.tbDateMax.Size = new System.Drawing.Size(91, 25);
            this.tbDateMax.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(472, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "~";
            // 
            // tbDateMin
            // 
            this.tbDateMin.Location = new System.Drawing.Point(390, 61);
            this.tbDateMin.Name = "tbDateMin";
            this.tbDateMin.Size = new System.Drawing.Size(76, 25);
            this.tbDateMin.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(300, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "주문날쨔 : ";
            // 
            // tbBookId2
            // 
            this.tbBookId2.Location = new System.Drawing.Point(91, 23);
            this.tbBookId2.Name = "tbBookId2";
            this.tbBookId2.Size = new System.Drawing.Size(110, 25);
            this.tbBookId2.TabIndex = 11;
            // 
            // tbPrice2
            // 
            this.tbPrice2.Location = new System.Drawing.Point(77, 61);
            this.tbPrice2.Name = "tbPrice2";
            this.tbPrice2.Size = new System.Drawing.Size(191, 25);
            this.tbPrice2.TabIndex = 11;
            // 
            // tbCustId2
            // 
            this.tbCustId2.Location = new System.Drawing.Point(498, 25);
            this.tbCustId2.Name = "tbCustId2";
            this.tbCustId2.Size = new System.Drawing.Size(92, 25);
            this.tbCustId2.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(19, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "가격 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(16, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "책보노 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(406, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "고객보노 :";
            // 
            // tbOrderId
            // 
            this.tbOrderId.Location = new System.Drawing.Point(310, 25);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(86, 25);
            this.tbOrderId.TabIndex = 1;
            // 
            // tbOdersId
            // 
            this.tbOdersId.AutoSize = true;
            this.tbOdersId.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbOdersId.Location = new System.Drawing.Point(218, 28);
            this.tbOdersId.Name = "tbOdersId";
            this.tbOdersId.Size = new System.Drawing.Size(86, 17);
            this.tbOdersId.TabIndex = 0;
            this.tbOdersId.Text = "주문보노 :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(665, 505);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 100);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(665, 405);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 92);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tables.ResumeLayout(false);
            this.tables.PerformLayout();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbOrders.ResumeLayout(false);
            this.gbOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tables;
        private System.Windows.Forms.RadioButton rbOrders;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCustId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.TextBox tbDateMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDateMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbBookId2;
        private System.Windows.Forms.TextBox tbPrice2;
        private System.Windows.Forms.TextBox tbCustId2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Label tbOdersId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbPublisher;
    }
}


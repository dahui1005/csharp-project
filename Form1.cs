using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjectBook
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbBook.Visible = false;
            gbCustomer.Visible = false;
            gbOrders.Visible = false;
            string connStr = "server=localhost;port=3306;database=mydb;uid=root;pwd=dlaekgml; allow user variables=true";
            conn = new MySqlConnection(connStr);

            SetSearchComboBox();
        }

        #region 라디오버튼
        private void tableChangeed(string table)
        {
            dataAdapter = new MySqlDataAdapter($"SELECT * FROM {table}", conn);
            dataSet = new DataSet();


            dataAdapter.Fill(dataSet, table);
            dataGridView1.DataSource = dataSet.Tables[table];
        }
        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                gbBook.Visible = true;

                tableChangeed("book");


            }
            else
            {
                gbBook.Visible = false;
            }
        }

        // **** 검색 조건 ComboBox에 CountryCode 목록 세팅 ****
        private void SetSearchComboBox()
        {
            string sql = "SELECT distinct publisher FROM book";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // CountryCode 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbPublisher.Items.Add(reader.GetString("publisher"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked == true)
            {
                gbCustomer.Visible = true;
                tableChangeed("customer");
            }
            else
            {
                gbCustomer.Visible = false;
            }
        }

        private void rbOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrders.Checked == true)
            {
                gbOrders.Visible = true;
                tableChangeed("orders");
            }
            else
            {
                gbOrders.Visible = false;
            }
        }
        #endregion

        #region 셀렉트
        private void btnSelect_Click(object sender, EventArgs e)
        {

            if (rbBook.Checked)
                bookTableSelect_Checked();
            else if (rbCustomer.Checked)
                custTableSelect_Checked();
            else
                ordersTableSelect_Checked();
        }

        private void ordersTableSelect_Checked()
        {
            string queryStr;

            string[] conditions = new string[5];
            conditions[0] = (tbOrderId.Text != "") ? "orderid=@orderid" : null;
            conditions[1] = (tbCustId2.Text != "") ? "custid=@custid" : null;
            conditions[2] = (tbBookId2.Text != "") ? "bookid=@bookid" : null;
            conditions[3] = (tbPrice2.Text != "") ? "saleprice=@saleprice" : null;

            string condition_orderdate;
            if (tbDateMin.Text != "" && tbDateMax.Text != "")
            {
                condition_orderdate = "orderdate>=@min and orderdate<=@max";
            }
            else if (tbDateMin.Text != "" || tbDateMax.Text != "")
            {
                if (tbDateMin.Text != "")
                    condition_orderdate = "orderdate>=@min";
                else
                    condition_orderdate = "orderdate <= @max";
            }
            else
            {
                condition_orderdate = null;
            }
            conditions[4] = condition_orderdate;


            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM orders WHERE ";
                bool firstCondition = true;

                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM orders";
            }

            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@orderid", tbOrderId.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@custid", tbCustId2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid", tbBookId2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@saleprice", tbPrice2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min", tbDateMin.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max", tbDateMax.Text);


            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "orders") > 0)
                    dataGridView1.DataSource = dataSet.Tables["orders"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void custTableSelect_Checked()
        {
            string queryStr;

            string[] conditions = new string[4];
            conditions[0] = (tbCustId.Text != "") ? "custid=@custid" : null;
            conditions[1] = (tbAddress.Text != "") ? "address=@address" : null;
            conditions[2] = (tbName.Text != "") ? "name=@name" : null;
            conditions[3] = (tbPhone.Text != "") ? "phone=@phone" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = $"SELECT * FROM customer WHERE ";
                bool firstCondition = true;

                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM customer";
            }
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@custid", tbCustId.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@address", tbAddress.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", tbName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@phone", tbPhone.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "customer") > 0)
                    dataGridView1.DataSource = dataSet.Tables["customer"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bookTableSelect_Checked()
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[4];
            conditions[0] = (tbBookId.Text != "") ? "bookid=@bookid" : null;
            conditions[1] = (tbBookName.Text != "") ? "bookname=@bookname" : null;
            conditions[2] = (cbPublisher.Text != "") ? "publisher=@publisher" : null;
            conditions[3] = (tbPrice.Text != "") ? "price=@price" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = $"SELECT * FROM book WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM book";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid", tbBookId.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@bookname", tbBookName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@publisher", cbPublisher.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@price", tbPrice.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "book") > 0)
                    dataGridView1.DataSource = dataSet.Tables["book"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 인서트
        private void bookTableRow_Click()
        {
            tbBookId.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tbBookName.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            cbPublisher.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
            tbPrice.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
        }

        private void custTableRow_Click()
        {
            tbCustId.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tbName.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            tbAddress.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
            tbPhone.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
        }

        private void ordersTableRow_Click()
        {
            tbOrderId.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tbCustId2.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            tbBookId2.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
            tbPrice2.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
            tbDateMin.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
                bookTableInsert_Checked();
            else if (rbCustomer.Checked)
                custTableInsert_Checked();
            else
                ordersTableInsert_Checked();
        }

        private void bookTableInsert_Checked()
        {
            string[] rowDatas = {
                tbBookId.Text,
                tbBookName.Text,
                cbPublisher.Text,
                tbPrice.Text };

            string queryStr = "INSERT INTO book (bookid, bookname, publisher, price) " +
                "VALUES(@bookid, @bookname, @publisher, @price)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@bookname", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@publisher", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@price", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@bookid"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@bookname"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@publisher"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@price"].Value = rowDatas[3];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "book");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["book"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void custTableInsert_Checked()
        {
            string[] rowDatas = {
                tbCustId.Text,
                tbName.Text,
                tbAddress.Text,
                tbPhone.Text };

            string queryStr = "INSERT INTO customer (custid, name, address, phone) " +
                "VALUES(@custid, @name, @address, @phone)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@custid", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@address", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@phone", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@custid"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@name"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@address"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@phone"].Value = rowDatas[3];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "customer");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["customer"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void ordersTableInsert_Checked()
        {
            string[] rowDatas = {
                tbOrderId.Text,
                tbCustId2.Text,
                tbBookId2.Text,
                tbPrice2.Text,
                tbDateMin.Text };

            string queryStr = "INSERT INTO orders (orderid, custid, bookid, saleprice, orderdate) " +
                "VALUES(@orderid, @custid, @bookid, @saleprice, @orderdate)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@orderid", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@custid", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@saleprice", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@orderdate", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@orderid"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@custid"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@bookid"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@saleprice"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@orderdate"].Value = rowDatas[4];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "orders");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["orders"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;

            if (selectedRowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            if (rbBook.Checked) bookTableRow_Click();
            else if (rbCustomer.Checked) custTableRow_Click();
            else ordersTableRow_Click();
        }
        #endregion

        #region 업데이트
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
                bookTableUpdate_Checked();
            else if (rbCustomer.Checked)
                custTableUpdate_Checked();
            else
                ordersTableUpdate_Checked();
        }

        private void bookTableUpdate_Checked()
        {
            string[] rowDatas = {
                tbBookId.Text,
                tbBookName.Text,
                cbPublisher.Text,
                tbPrice.Text };

            string sql = "UPDATE book SET bookid=@bookid, bookname=@bookname, publisher=@publisher, price=@price WHERE bookid=@bookid";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookname", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@publisher", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@price", rowDatas[3]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "book");
                dataGridView1.DataSource = dataSet.Tables["book"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void custTableUpdate_Checked()
        {
            string[] rowDatas = {
                tbCustId.Text,
                tbName.Text,
                tbAddress.Text,
                tbPhone.Text };

            string sql = "UPDATE customer SET custid=@custid, name=@name, address=@address, phone=@phone WHERE custid=@custid";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@address", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@phone", rowDatas[3]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "customer");
                dataGridView1.DataSource = dataSet.Tables["customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ordersTableUpdate_Checked()
        {
            string[] rowDatas = {
                tbOrderId.Text,
                tbCustId2.Text,
                tbBookId2.Text,
                tbPrice2.Text,
                tbDateMin.Text };

            string sql = "UPDATE orders SET orderid=@orderid, custid=@custid, bookid=@bookid, saleprice=@saleprice, orderdate=@orderdate WHERE orderid=@orderid";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderid", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@saleprice", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderdate", rowDatas[4]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "orders");
                dataGridView1.DataSource = dataSet.Tables["orders"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
                bookTableDelete_Checked();
            else if (rbCustomer.Checked)
                custTableDelete_Checked();
            else
                ordersTableDelete_Checked();
        }

        private void bookTableDelete_Checked()
        {
            string sql = "DELETE FROM book WHERE bookid=@bookid";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@bookid", tbBookId.Text);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "book");
                dataGridView1.DataSource = dataSet.Tables["book"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void custTableDelete_Checked()
        {
            string sql = "DELETE FROM customer WHERE custid=@custid";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@custid", tbCustId.Text);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "customer");
                dataGridView1.DataSource = dataSet.Tables["customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ordersTableDelete_Checked()
        {
            string sql = "DELETE FROM orders WHERE orderid=@orderid";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@orderid", tbOrderId.Text);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "orders");
                dataGridView1.DataSource = dataSet.Tables["orders"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
                bookTableClear_Checked();
            else if (rbCustomer.Checked)
                custTableClear_Checked();
            else
                ordersTableClear_Checked();
        }

        private void bookTableClear_Checked()
        {
            tbBookId.Clear();
            tbBookName.Clear();
            cbPublisher.Text = "";
            tbPrice.Clear();
        }

        private void custTableClear_Checked()
        {
            tbCustId.Clear();
            tbName.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
        }

        private void ordersTableClear_Checked()
        {
            tbOrderId.Clear();
            tbBookId2.Clear();
            tbCustId2.Clear();
            tbPrice2.Clear();
            tbDateMin.Clear();
            tbDateMax.Clear();
        }
    }
}
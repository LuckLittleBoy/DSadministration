using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    #region 进货表
    public partial class btnGoodsInBook1 : Form
    {
        #region 初始化
        public drugsroreContext drug = new drugsroreContext();
        public int ListLength = 20;
        public string[] SelectList = new string[20];
        /// <summary>
        /// 窗体构造函数
        /// </summary>
        public btnGoodsInBook1()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region 初始化checkedlistbox中的选择项
        /// <summary>
        /// 在checkedlistbox中显示数据库中药品种类名称
        /// </summary>
        public void Init()
        {
            drugsroreContext drug = new drugsroreContext();
            var result = (from u in drug.Medicines select u);
            int i = 0;
            foreach (var item in result)
            {
                this.checkedListBox1.Items.AddRange(new object[]
                    {
                        item.NAME
                    });
                i++;
            }

        }
        #endregion

        #region 删除行
        /// <summary>
        /// 行的删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.skinDataGridView1.Columns[e.ColumnIndex].Name == "DeleteRow")
            {
                this.skinDataGridView1.Rows.RemoveAt(skinDataGridView1.CurrentCell.RowIndex);
                this.textBox1.Text = "0";
                for (int i = 0; i < this.skinDataGridView1.RowCount; i++)
                {
                    this.textBox1.Text = Convert.ToString(Convert.ToDouble(this.skinDataGridView1.Rows[i].Cells[7].Value) * Convert.ToInt32(this.skinDataGridView1.Rows[i].Cells[10].Value) + Convert.ToDouble(this.textBox1.Text));
                }
            }
        }
        #endregion

        #region 添加药品点击事件
        /// <summary>
        /// 初始化存放checkedListBox中选项的SelectList数组
        /// 显示添加药品界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListLength; i++)
            {
                SelectList[i] = "";
            }
            ListLength = 0;
            this.skinPanel1.Visible = true;
        }
        #endregion

        #region 添加药品界面保存按钮点击事件
        /// <summary>
        /// 将checkedListBox中已选的item赋值给SelectList数组
        /// checkedListBox置空
        /// 调用table表显示方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.CheckedItems.Count; i++)
            {
                this.SelectList[i] = this.checkedListBox1.CheckedItems[i].ToString();
                this.ListLength++;
            }
            foreach (int i in this.checkedListBox1.CheckedIndices)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            this.skinPanel1.Hide();
            TableDisplay();
        }
        #endregion

        #region 在table表中显示checkedlistbox中的选择在数据库中其他项的内容
        /// <summary>
        /// table表显示方法
        /// </summary>
        public void TableDisplay()
        {
                for (int i = 0; i < ListLength; i++)
                {
                    this.skinDataGridView1.Rows.Add();
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[2].Value = SelectList[i];
                    var result = drug.Medicines.Find(SelectList[i]);
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[1].Value = result.ID;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[3].Value = result.DOSAGE;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[4].Value = result.MOLECULES;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[5].Value = result.STOCK_NUM;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[6].Value = result.PROADRESS;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[7].Value = result.LOTSELL_PRICE;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[8].Value = result.SELL_PRICE;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[9].Value = result.REMARKS;
                    this.skinDataGridView1.Rows[this.skinDataGridView1.RowCount - 1].Cells[10].Value = result.NUMBER;
                }
        }
        #endregion

        #region 添加药品界面关闭按钮点击事件
        /// <summary>
        /// 关闭添加药品界面
        /// checkedListBox置空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton5_Click(object sender, EventArgs e)
        {
            foreach (int i in this.checkedListBox1.CheckedIndices)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }

            this.skinPanel1.Hide();

        }
        #endregion

        #region 新增药品种类
        /// <summary>
        /// 新增药品单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton6_Click(object sender, EventArgs e)
        {
            this.addDrugs.Visible = true;
            this.skinComboBox2.SelectedItem = "0";
            this.skinPanel1.Hide();
        }

        /// <summary>
        /// 新增药品种类界面确定按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton8_Click(object sender, EventArgs e)
        {
            drugsroreContext drug = new drugsroreContext();
            Medicine medicine = new Medicine();
            
            if (this.skinTextBox1.Text.Equals("") || this.skinTextBox1.Text == null)
            {
                MessageBox.Show("请输入药品名称！");
            }
            else if(isRepeatName(drug, medicine))
            {
                MessageBox.Show("药品名称重复！");
            }
            else
            {    
                medicine.ID = "";
                medicine.NAME = this.skinTextBox1.Text;
                medicine.DOSAGE = this.skinTextBox2.Text;
                medicine.MOLECULES = this.skinComboBox2.Text;
                medicine.STOCK_NUM = 0;

                medicine.PROADRESS = this.skinTextBox3.Text;
                medicine.LOTSELL_PRICE = this.skinTextBox4.Text;
                medicine.SELL_PRICE = this.skinTextBox5.Text;

                drug.Medicines.Add(medicine);
                drug.SaveChanges();
                MessageBox.Show("新增成功");
                this.addDrugs.Hide();
                var result = (from u in drug.Medicines where u.NAME == this.skinTextBox1.Text.Trim() select u);
                foreach (var item in result)
                {
                    this.checkedListBox1.Items.AddRange(new object[]
                    {
                        item.NAME
                    });
                }

                foreach (Control c in this.addDrugs.Controls)//遍历所有控件
                {
                    if (c is SkinTextBox)//判断是否是textBox控件，是则清空
                    {
                        c.Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// 判断所输药品名称是否与数据库中冲突
        /// </summary>
        /// <param name="drug"></param>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public bool isRepeatName(drugsroreContext drug, Medicine medicine)
        {
            var data = from u in drug.Medicines select u;
            foreach (var item in data)
            {
                if (item.NAME == this.skinTextBox1.Text.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 新增药品种类界面取消按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton7_Click(object sender, EventArgs e)
        {
            this.skinComboBox2.SelectedItem = -1;
            foreach (Control c in this.addDrugs.Controls)//遍历所有控件
            {
                if (c is SkinTextBox)//判断是否是textBox控件，是则清空
                {
                    c.Text = "";
                }
            }
        }

        /// <summary>
        /// 新增药品种类界面关闭按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton9_Click(object sender, EventArgs e)
        {
            this.addDrugs.Hide();
            foreach (Control c in this.addDrugs.Controls)//遍历所有控件
            {
                if (c is SkinTextBox)//判断是否是textBox控件，是则清空
                {
                    c.Text = "";
                }
            }
        }

        #endregion

        #region 实时确定所购药品的总价格
        /// <summary>
        /// table表焦点监听事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int num = 0;
            
            if (this.skinDataGridView1.Rows[e.RowIndex].Cells[10].Value != null)
            {
                if (int.TryParse(this.skinDataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString(), out num))
                {
                    if (num > 0)
                    {
                        this.textBox1.Text = "0";
                        for (int i = 0; i < this.skinDataGridView1.RowCount; i++)
                        {
                            this.textBox1.Text = Convert.ToString(Convert.ToDouble(this.skinDataGridView1.Rows[i].Cells[7].Value) * Convert.ToInt32(this.skinDataGridView1.Rows[i].Cells[10].Value) + Convert.ToDouble(this.textBox1.Text));
                        }
                    }

                    else
                    {
                        MessageBox.Show("请输入正整数！");
                    }
                }

                else 
                {
                    MessageBox.Show("请输入正整数！");
                }
            }
        }

        /// <summary>
        /// 实付款文本框内容改变监听事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (this.textBox2.Text != "" && this.textBox1.Text != "")
            {
                if (double.TryParse(this.textBox2.Text, out num))
                {
                    if (num >= 0)
                    {
                        this.textBox3.Text = Convert.ToString(Convert.ToDouble(this.textBox1.Text) - Convert.ToDouble(this.textBox2.Text));
                    }

                    else
                    {
                        MessageBox.Show("请输入正数！");
                        this.textBox2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("请输入正数！");
                    this.textBox2.Text = "";
                }
            }
            if (this.textBox2.Text == "")
            {
                this.textBox3.Text = this.textBox1.Text;
            }
        }

        #endregion


        /// <summary>
        /// 进货单保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (this.skinComboBox1.Text != ""&&this.skinDateTimePicker1.Text!="")
            {
                if (this.textBox1.Text != "")
                {
                    if (this.textBox2.Text != "")
                    {
                        /*
                        drugsroreContext drug = new drugsroreContext();
                        INSTOCK instock = new INSTOCK();
                        INSTOCK_MONEY instock_money = new INSTOCK_MONEY();
                        STOCK stock = new STOCK();

                        for (int i = 0; i < this.skinDataGridView1.RowCount; i++)
                        {
                            instock.INSTOCK_ID = this.skinLabel4.Text;
                            instock.INSTOCK_DATE = this.skinDateTimePicker1.Text;
                            instock.INSTOCK_PROOF_ID = this.skinLabel4.Text;
                            instock.FK_SUPPLIER_ID = this.skinComboBox1.Text;
                            instock.FK_STAFF_ID = "";
                            instock.INSTOCK_OTHERS = "";
                            instock.FK_DRUG_ID = this.skinDataGridView1.Rows[i].Cells[1].Value.ToString();
                            instock.FK_DRUG_NAME = this.skinDataGridView1.Rows[i].Cells[2].Value.ToString();
                            instock.INSTOCK_LOTBUY_PRICE = this.skinDataGridView1.Rows[i].Cells[7].Value.ToString();
                            instock.INSTOCK_SELL_PRICE = this.skinDataGridView1.Rows[i].Cells[8].Value.ToString();
                            instock.INSTOCK_REMARKS = this.skinDataGridView1.Rows[i].Cells[9].Value.ToString();
                            instock.INSTOCK_NUM = Convert.ToInt32(this.skinDataGridView1.Rows[i].Cells[10].Value);

                            instock_money.IM_DATE = this.skinDateTimePicker1.Text;
                            instock_money.IM_PROOF_ID = this.skinLabel4.Text;
                            instock_money.IM_SUPPLIER_NAME = this.skinComboBox1.Text;
                            instock_money.IM_TOTAL_PRICE = this.textBox1.Text;
                            instock_money.IM_REAL_PAYMENT = this.textBox2.Text;
                            instock_money.IM_DEBT_PAYMENT = this.textBox3.Text;
                            instock_money.IM_REMARKS = this.skinTextBox9.Text;*/ 

                            //stock.DRUG_ID = this.skinDataGridView1.Rows[i].Cells[1].Value.ToString(); /*药品编号*/
                            //stock.DRUG_NAME = this.skinDataGridView1.Rows[i].Cells[2].Value.ToString();  /*药品名称*/
                            //stock.DRUG_DOSAGE = this.skinDataGridView1.Rows[i].Cells[3].Value.ToString(); /*剂量*/
                           // stock.DRUG_MOLECULES = this.skinDataGridView1.Rows[i].Cells[4].Value.ToString(); /*单位*/
                            //stock.DRUG_STOCK_NUM = Convert.ToInt32(this.skinDataGridView1.Rows[i].Cells[5].Value); /*库存量*/
                            //stock.DRUG_PROADRESS = this.skinDataGridView1.Rows[i].Cells[6].Value.ToString();        /*产地*/
                           // DRUG_LOTSELL_PRICE = 
                            //DRUG_PACK_NUM          /*包装数量*/

       
                            //DRUG_EFFECTIVE_DATE    /*有效期*/
                            //DRUG_LOT_NUM         /*批号*/
                           // DRUG_CATEGORY          /*类别*/
                            //DRUG_SELL_PRICE      /*零售价*/
                          //  DRUG_LOTSELL_PRICE     /*批发价*/
                           // DRUG_REMARKS           /*备注*/
                           // DRUG_OTHERS               /*其他*/
                                
                        //}

                    }

                    else
                    {
                        MessageBox.Show("请先付款！");
                    }
                }

                else
                {
                    MessageBox.Show("请选择药品！");
                }
            }

            else
            {
                MessageBox.Show("请完善信息！");
            }
        }
    }

    #endregion
}

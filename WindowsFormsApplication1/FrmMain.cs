using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace WindowsFormsApplication1
{
    public partial class FrmMain : Form
    {
        
        #region 构造函数
        
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion
   
        #region 创建tab页方法
        /// <summary>
        /// 创建tab页
        /// </summary>
        /// <param name="form">新建的窗体</param>
        /// <param name="tabItemName">tabItem的Name属性</param>
        /// <param name="panelName">TabPanel的Name属性</param>
        public void CreateTabControl(Form form, string tabItemName, string panelName)
        {
            TabItem tabItemNew = new TabItem();
            TabControlPanel tabControlPanelNew = new TabControlPanel();
            tabControlPanelNew.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlPanelNew.Name = panelName;
            tabControlPanelNew.TabItem = tabItemNew;
            tabItemNew.AttachedControl = tabControlPanelNew;
            tabItemNew.Name = tabItemName;

            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Parent = tabControlPanelNew;
            form.Dock = DockStyle.Fill;
            tabControlPanelNew.Controls.Add(form);
            form.Show();
            tabItemNew.Text = form.Text;
            tabControl1.Controls.Add(tabControlPanelNew);
            tabControl1.Tabs.Add(tabItemNew);
            tabControl1.Refresh();
            tabControl1.SelectedTab = tabItemNew;
        }
        /// <summary>
        /// 判断新建的tab标签在原有标签中是否存在；
        /// </summary>
        /// <param name="TabItemName"></param>
        /// <returns></returns>
        public bool tabIsSingleCheck(string TabItemName)
        {
            foreach (TabItem tab in tabControl1.Tabs)
            {
                if (tab.Text.Equals(TabItemName))
                {
                    tabControl1.SelectedTab = tab;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region 加载窗体
        /// <summary>
        /// 窗体加载时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.expandablePanel1.Expanded = true;
            this.btnGoodsInManage.Expanded = false;
            this.expandablePanel3.Expanded = false;
            this.expandablePanel4.Expanded = false;
            this.expandablePanel5.Expanded = false;
            this.expandablePanel6.Expanded = false;
        }
        #endregion

        #region 仓库管理

        /// <summary>
        /// 查看库存的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnslStorehouse_Click(object sender, EventArgs e)
        {
            slStorehouse form1 = new slStorehouse();
            if (tabIsSingleCheck(form1.Text) != true)
            {
                CreateTabControl(form1, this.btnslStorehouse.Text, this.btnslStorehouse.Text);
            }
        }

        #endregion

        #region 进货管理
        /// <summary>
        /// 进货单单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoodsInBook1_Click(object sender, EventArgs e)
        {
            btnGoodsInBook1 form = new btnGoodsInBook1();
            if (tabIsSingleCheck(form.Text) != true)
            {
                CreateTabControl(form, this.btnslStorehouse.Text, this.btnslStorehouse.Text);
            }
        }
        #endregion

        private void skinLabel4_Click(object sender, EventArgs e)
        {

        }

        #region 主页快速索引
        /// <summary>
        /// 通过主页查看库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinPictureBox5_Click(object sender, EventArgs e)
        {
            slStorehouse form1 = new slStorehouse();
            if (tabIsSingleCheck(form1.Text) != true)
            {
                CreateTabControl(form1, this.btnslStorehouse.Text, this.btnslStorehouse.Text);
            }
        }
        #endregion

        /// <summary>
        /// 通过主页快速进货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinPictureBox8_Click(object sender, EventArgs e)
        {
            btnGoodsInBook1 form = new btnGoodsInBook1();
            if (tabIsSingleCheck(form.Text) != true)
            {
                CreateTabControl(form, this.btnGoodsInBook1.Text, this.btnGoodsInBook1.Text);
            }
        }

        /// <summary>
        /// 通过主页快速售货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinPictureBox9_Click(object sender, EventArgs e)
        {
            SellGoods form = new SellGoods();
            if (tabIsSingleCheck(form.Text) != true)
            {
                CreateTabControl(form, this.btnSaleNote.Text, this.btnSaleNote.Text);
            }
        }

        private void skinPictureBox6_Click(object sender, EventArgs e)
        {
            FundsManagement form = new FundsManagement();
            if (tabIsSingleCheck(form.Text) != true)
            {
                CreateTabControl(form, form.Text, form.Text);
            }
        }

        private void skinPictureBox10_Click(object sender, EventArgs e)
        {
            Suggestion form = new Suggestion();
            if (tabIsSingleCheck(form.Text) != true)
            {
                CreateTabControl(form, this.expandablePanel4.TitleText, this.expandablePanel4.TitleText);
            }
        }
    }
}

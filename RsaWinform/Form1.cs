using RSATools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsaWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 生成密钥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGen_Click(object sender, EventArgs e)
        {
            RSAHelper.RSAKey keyPair = RSAHelper.GetRASKey();//生成密钥
            txtPK.Text = keyPair.PublicKey;//生成公钥，用于解密
            txtSK.Text = keyPair.PrivateKey;//生成私钥，用于加密
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnS_Click(object sender, EventArgs e)
        {
            string sk = txtSK.Text.Trim();
            string str = txtContext.Text.Trim();
            txtSed.Text= RSAHelper.EncryptString(str, sk);
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDs_Click(object sender, EventArgs e)
        {
          txtDsed.Text=  RSAHelper.DecryptString(txtSed.Text.Trim(), txtPK.Text.Trim());
        }
    }
}

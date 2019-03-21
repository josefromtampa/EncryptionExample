using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        string enc = ManagedAesSample.EncryptToString(txtToEnc.Text, txtKey.Text);
        txtEnc.Text = enc;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.ToString());
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        string dec = ManagedAesSample.DecryptFromString(txtEnc.Text, txtKey.Text);
        txtDec.Text = dec;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.ToString());
      }
    }
  }
}

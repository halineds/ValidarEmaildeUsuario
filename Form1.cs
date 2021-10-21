using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailValidarCsharp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnValidarEmail_Click(object sender, EventArgs e) {
            if (Validar.IsValidEmail(txtEmail.Text))
                MessageBox.Show("Email válido");
            else
                MessageBox.Show("Email inválido");
        }
    }
}

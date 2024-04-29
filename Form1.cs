using System.Net;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using System.Xml;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Data;
using OpenQA.Selenium.DevTools.V121.Fetch;

namespace formscraper
{
    public partial class Form1 : Form
    {
        public string Matriculafuncionario, Senhafuncionario;
        public Form1()
        {
            InitializeComponent();
        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Botao_Consulta_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            //string arqucsv = @"d:\tabela.csv";
            //string arqucsv2 = @"d:\tabela2.csv";
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("user-dada-dir=" + path + "ChromeDriver\\cache");
            ChromeDriver driver = new ChromeDriver();


            // driver.Navigate().GoToUrl("https://www.mercadolivre.com.br/");
            //driver.Navigate().GoToUrl("file:///D:/download/resultado.caixaAG1623Abrcp2.htm");
            driver.Navigate().GoToUrl("https://resultado.caixa/2024/#/resultado/202404/1623");



            IWebElement botaoexpandir = driver.FindElement(By.CssSelector("button[title*='Expandir/Recolher']"));
            IReadOnlyCollection<IWebElement> listatudo = driver.FindElements(By.CssSelector("tr[class*='itemNivel']")).ToList();
            IReadOnlyCollection<IWebElement> listatudo2 = driver.FindElements(By.CssSelector("td[class*='valorG']")).ToList();
            IReadOnlyCollection<IWebElement> listatudo3 = driver.FindElements(By.CssSelector("td[class*='peso']")).ToList();
            //<td class="valorG d-none d-lg-table-cell"></td>
            botaoexpandir.Click();
            string sep = "";
            StringBuilder textoconcatenado = new StringBuilder();
            foreach (IWebElement linha2 in listatudo2)
            {
                caixadetexto4.AppendText($"{linha2.Text}\n");
                //textoconcatenado.Append($"{linha.Text}\n");
                // tabelao.Rows.Add(linha.Text.Substring(4,10), linha.Text.Substring(11, 10), linha.Text.Substring(22, 10), linha.Text.Substring(32, 10)) ;            }
            }
            foreach (IWebElement linha3 in listatudo3)
            {
                caixadetexto5.AppendText($"{linha3.Text}\n");
            }
            int ll = -1;
            foreach (IWebElement linha in listatudo)
            {
                string itemdorelatorio = linha.FindElement(By.CssSelector("a")).Text;
                //string valores2 = linha.FindElement(By.ClassName("peso")).Text;
                ll++;
                tabelao.Rows.Add();
                //string pesos = linha.FindElement(By.CssSelector("td[class*='peso']")).Text;
                tabelao.Rows[ll].Cells[0].Value = itemdorelatorio;
            }
            int ll2 = 0;
            int l1 = 3;
            int l2 = 4;
            int l3 = 5;

            foreach (IWebElement linha2 in listatudo2)
            {
                string itemdorelatorio2 = linha2.Text;
                //string itemdorelatorio2 = linha2.FindElement(By.CssSelector("td")).Text;
                //string valores = linha.FindElement(By.ClassName("valorG")).Text;
                //string valores2 = linha.FindElement(By.ClassName("peso")).Text;
                // tabelao.Rows.Add();
                //string pesos = linha.FindElement(By.CssSelector("td[class*='peso']")).Text;
                //tabelao.Rows[ll].Cells[1].Value = valores;
                //tabelao.Rows[ll].Cells[2].Value = valores2;
                //tabelao.Rows[ll].Cells[3].Value = ll;
                ll2++;
                if (ll >= ll2)
                {
                    tabelao.Rows[ll2].Cells[1].Value = caixadetexto4.Lines[l1].ToString();
                    tabelao.Rows[ll2].Cells[3].Value = caixadetexto4.Lines[l2].ToString();
                    //tabelao.Rows[ll2].Cells[3].Value = caixadetexto4.Lines[l3].ToString();

                }
                l1 = l1 + 3;
                l2 = l2 + 3;
                l3 = l3 + 3;

                if ((ll == ll2) || (ll < ll2))
                {
                    continue;
                }


            }


            int ll3 = -1;
            int l4 = 0;
            int l5 = 1;
            foreach (IWebElement linha2 in listatudo2)
            {
                string itemdorelatorio2 = linha2.Text;
                ll3++;
                if (ll >= ll3)
                {
                    //tabelao.Rows[ll3].Cells[4].Value = caixadetexto5.Lines[l4].ToString();
                    tabelao.Rows[ll3].Cells[2].Value = caixadetexto5.Lines[l5].ToString();


                }
                l4 = l4 + 2;
                l5 = l5 + 2;


                if ((ll == ll3) || (ll < ll3))
                {
                    continue;
                }


            }



            driver.Quit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void caixadetexto4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
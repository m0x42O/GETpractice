using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpCalc
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            priceInitialType.SelectedIndex = 0;
            pricePeriodCombo.SelectedIndex = 0;
            priceAnnuitet.Checked = true;
            butPriceClear.Click += ClearFunc;
            butPriceGo.Click += butPriceGo_Click;
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            pricePrice.Focus();
        }

        private void butPriceGo_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(priceInitial.Value) > Convert.ToInt32(pricePrice.Value)) || (priceInitialType.SelectedIndex == 1 && Convert.ToInt32(priceInitial.Value) > 99))
            {
                MessageBox.Show("Сумма кредита не может быть отрицательной или равной нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvGrafik.Rows.Clear();
                double ValueOfPurchase = Convert.ToDouble(pricePrice.Value);
                double InitialPayment = Convert.ToDouble(priceInitial.Value);
                double SumCredit = 0;
                if (priceInitialType.SelectedIndex == 0)
                {
                    SumCredit += (ValueOfPurchase - InitialPayment);
                }
                else
                {
                    SumCredit += (ValueOfPurchase - ((ValueOfPurchase * InitialPayment) / 100));
                }
                priceCreditSum.Text += SumCredit;
                double InterestRateYear = Convert.ToDouble(priceProcent.Value); 
                double InterestRateMonth = InterestRateYear / 100 / 12; 
                int CreditPeriod = Convert.ToInt32(pricePeriod.Value);
                if (pricePeriodCombo.SelectedIndex == 0)
                    CreditPeriod *= 12;
                if (priceAnnuitet.Checked == true)
                {
                    PaymentScheduleAnnuitet(SumCredit, InterestRateYear, InterestRateMonth, CreditPeriod);
                }
                else if (priceDiffer.Checked == true) 
                {
                    PaymentScheduleDiffer(SumCredit, InterestRateMonth, CreditPeriod);
                }
            }
        }

        private void ClearFunc(object sender, EventArgs e)
        {
            pricePrice.Value = pricePrice.Minimum;
            priceInitial.Value = priceInitial.Minimum;
            priceInitialType.SelectedIndex = 0;
            priceProcent.Value = priceProcent.Minimum;
            pricePeriod.Value = pricePeriod.Minimum;
            pricePeriodCombo.SelectedIndex = 0;
            priceCreditSum.Clear();
            itogSum.Clear();
            itogOverpayment.Clear();
            itogPayment.Clear();
            dgvGrafik.Rows.Clear();
        }

        private void PaymentScheduleAnnuitet(double SumCredit, double InterestRateYear, double InterestRateMonth, int CreditPeriod)
        {
            double Payment = SumCredit * (InterestRateMonth / (1 - Math.Pow(1 + InterestRateMonth, -CreditPeriod)));
            double ItogCreditSum = Payment * CreditPeriod; 
            itogPayment.Text = Payment.ToString("N2"); 
            itogSum.Text = (ItogCreditSum).ToString("N2");                                                          
            double SumCreditOperation = SumCredit;
            double ItogCreditSumOperation = ItogCreditSum;
            double ItogPlus = 0;
            for (int i = 0; i < CreditPeriod; ++i)
            {
                double procent = SumCreditOperation * (InterestRateYear / 100) / 12;
                SumCreditOperation -= Payment - procent;
                dgvGrafik.Rows.Add();
                dgvGrafik[0, i].Value = i + 1;
                dgvGrafik[1, i].Value = Payment.ToString("N2");
                dgvGrafik[2, i].Value = (Payment - procent).ToString("N2");
                dgvGrafik[3, i].Value = procent.ToString("N2"); 
                dgvGrafik[4, i].Value = SumCreditOperation.ToString("N2");
                ItogCreditSumOperation -= Payment;
                ItogPlus = Convert.ToDouble(dgvGrafik[4, i].Value);
            }
            itogOverpayment.Text = (ItogCreditSum - SumCredit + ItogPlus).ToString("N2");
        }

        private void PaymentScheduleDiffer(double SumCredit, double InterestRateMonth, int CreditPeriod)
        {
            double MainPayment = SumCredit / CreditPeriod; 
            double ItogCreditSum = 0;
            double OverPaymentSum = 0;
            for (int i = 0; i < CreditPeriod; ++i)
            {
                double procentPart = SumCredit * InterestRateMonth; 
                SumCredit -= MainPayment; 
                dgvGrafik.Rows.Add(); 
                dgvGrafik[0, i].Value = i + 1; 
                dgvGrafik[1, i].Value = (MainPayment + procentPart).ToString("N2"); 
                dgvGrafik[2, i].Value = MainPayment.ToString("N2");
                dgvGrafik[3, i].Value = procentPart.ToString("N2");
                dgvGrafik[4, i].Value = SumCredit.ToString("N2"); 
            }
            for (int i = 0; i < CreditPeriod; ++i) 
            {
                ItogCreditSum += Convert.ToDouble(dgvGrafik[1, i].Value);
                OverPaymentSum += Convert.ToDouble(dgvGrafik[3, i].Value);
            }
            double ItogPlus = Convert.ToDouble(dgvGrafik[4, dgvGrafik.RowCount - 1].Value);
            itogSum.Text = ItogCreditSum.ToString("N2");
            itogOverpayment.Text = (OverPaymentSum + ItogPlus).ToString("N2");
            itogPayment.Text = Convert.ToString(dgvGrafik[1, 0].Value) + "..." + Convert.ToString(dgvGrafik[1, dgvGrafik.RowCount - 1].Value);
        }
    }
}

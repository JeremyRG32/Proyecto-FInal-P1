using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Management.Business;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Presentation
{
    public partial class Confirm_Payment : Form
    {
        private decimal amount;
        private int reservationid;
        Reservation reservation = new Reservation();
        public Confirm_Payment(Reservation reservation)
        {
            InitializeComponent();
            amount = reservation.Vehicle.Price;
            reservationid = reservation.ReservationId;
            
        }

        private void Confirm_Creation_Click(object sender, EventArgs e)
        {
            PaymentDTO paymentDTO = new PaymentDTO();
            paymentDTO = paymentDTO.PopulatePayment(reservation, boxpaymethod.Text);
            Payment payment = new Payment();
            payment.Addpayment(paymentDTO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

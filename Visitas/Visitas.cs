﻿using System;
using System.Windows.Forms;
using Visits.Repositories;

namespace Visits.App
{
    public partial class Visitas : Form
    {
        public Visitas()
        {
            InitializeComponent();

            InitialLoad();
        }

        private void InitialLoad()
        {
            var sellerRepository = new SellerRepository();
            var clientRespository = new ClientRepository();

            cbSeller.DataSource = sellerRepository.GetSellers();
            cbSeller.ValueMember = "SellerID";
            cbSeller.DisplayMember = "SellerName";

            cbDocType.DataSource = clientRespository.GetDocumentTypes();
            cbDocType.ValueMember = "DocumentTypeID";
            cbDocType.DisplayMember = "Abreviation";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var visitRepository = new VisitRepository();
            var clientRepository = new ClientRepository();
            var visit = new Visit();
            var client = new Client();

            client = clientRepository.GetClientByDocument(txtIdentification.Text.Trim(), int.Parse(cbDocType.SelectedValue.ToString()));

            visit.ClientID = client.ClientID;            
            visit.SellerID = int.Parse(cbSeller.SelectedValue.ToString());
            visit.Observations = txtObservations.Text.Trim();
            visit.VistDate = dtpVisitDate.Value;

            int result = visitRepository.SaveVisit(visit);

            if (result > 0) MessageBox.Show("La visita se registró correctamente.");

            ClearScreenData();
        }

        private void ClearScreenData()
        {
            txtClientName.Text = string.Empty;
            txtContactName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtObservations.Text = string.Empty;
        }

        private void txtIdentification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                FillClientData();
            }
        }

        private void FillClientData()
        {
            var clientRepository = new ClientRepository();
            var client = new Client();

            client = clientRepository.GetClientByDocument(txtIdentification.Text.Trim(), int.Parse(cbDocType.SelectedValue.ToString()));

            if (client != null)
            {
                txtClientName.Text = client.ClientName;
                txtContactName.Text = client.ContactName;
                txtPhone.Text = client.Phone;
                txtMail.Text = client.Email;
                txtAddress.Text = client.Address;
            }

        }

        private void txtIdentification_Leave(object sender, EventArgs e)
        {
            FillClientData();
        }
    }
}
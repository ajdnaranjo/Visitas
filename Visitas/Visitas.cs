using System;
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

            cbDocTypeSearch.DataSource = clientRespository.GetDocumentTypes();
            cbDocTypeSearch.ValueMember = "DocumentTypeID";
            cbDocTypeSearch.DisplayMember = "Abreviation";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var visitRepository = new VisitRepository();
            var clientRepository = new ClientRepository();
            var visit = new Visit();
            var client = new Client();

            //client = clientRepository.GetClientByDocument(txtIdentification.Text.Trim(), int.Parse(cbDocType.SelectedValue.ToString()));

           
            var c = new Client();
            c.Document = txtIdentification.Text.Trim();
            c.DocumentType = int.Parse(cbDocType.SelectedValue.ToString());
            c.ClientName = txtClientName.Text.Trim();
            c.ContactName = txtContactName.Text.Trim();
            c.Email = txtMail.Text.Trim();
            c.Phone = txtPhone.Text.Trim();
            c.Address = txtAddress.Text.Trim();
            c.Position = txtPosition.Text.Trim();
            c.Consumption = txtConsumption.Text.Trim();
            c.Fabric = txtFabric.Text.Trim();
            client = clientRepository.SaveClient(c);
          

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
            cbDocType.SelectedValue = "-1";
            txtIdentification.Text = string.Empty;
            txtPosition.Text = string.Empty;
            txtConsumption.Text = string.Empty;
            txtFabric.Text = string.Empty;
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
            var visitRepo = new VisitRepository();
            var client = new Client();

            client = clientRepository.GetClientByDocument(txtIdentification.Text.Trim(), int.Parse(cbDocType.SelectedValue.ToString()));            

            if (client != null)
            {
                txtClientName.Text = client.ClientName;
                txtContactName.Text = client.ContactName;
                txtPhone.Text = client.Phone;
                txtMail.Text = client.Email;
                txtAddress.Text = client.Address;
                txtPosition.Text = client.Position;
                txtConsumption.Text = client.Consumption;
                txtFabric.Text = client.Fabric;                               
            }

        }

        private void txtIdentification_Leave(object sender, EventArgs e)
        {
            if (cbDocType.SelectedValue.ToString() != "-1" &&  txtIdentification.Text.Trim() != string.Empty)
                FillClientData();
            
        }
      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var repo = new ClientRepository();
            var repoVisit = new VisitRepository();
            var client =  repo.GetClientByDocument(txtIDSearch.Text.Trim(), int.Parse(cbDocTypeSearch.SelectedValue.ToString()));

            var visits = repoVisit.GetVisitByID(client.ClientID);

            var obs = string.Empty;
            foreach (Visit r in visits)
            {
                obs = obs + " - " + r.Observations;
            }           
            txtSearchObservations.Text = obs;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

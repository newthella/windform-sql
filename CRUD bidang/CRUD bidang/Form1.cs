namespace CRUD_bidang
{
    partial class Form1 : Form
    {
        Model model;
        public Form1(Model model)
        {
            InitializeComponent();
            this.model = model;
            List<string> list_bidang = model.getAllBidang(); //mengambil data seluruh bidang dari tabel bidang di database
            cbx_bidang.DataSource = list_bidang; //memasukkan data dari database ke dropdown
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string bidang = cbx_bidang.Text; //mengambil inputan dari combobox
            int id_bidang = model.getIdBidang(bidang); //mengambil id bidang untuk ditambahkan di tabel prestasi
            //selanjutnya mengirim ke tabel prestasi
        }
    }
}
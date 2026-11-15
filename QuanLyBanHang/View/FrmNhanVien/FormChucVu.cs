using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;

namespace QuanLyBanHang.View.FrmNhanVien
{
    public partial class FormChucVu : Form
    {
        private IQLchucVuServices qLchucVuServices;
        public chucVu _chucVu;
        public FormChucVu()
        {
            _chucVu = new chucVu();
            InitializeComponent();
            qLchucVuServices = new QLchucVuServices();
        }
        public void load()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 2;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[1].Name = "Position";
            foreach (var item in qLchucVuServices.GetchucVuFromDB())
            {
                dtg_show.Rows.Add(item.IDChucVu, item.tenCV);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //chucVu accchucvu = qLchucVuServices.GetchucVuFromDB().FirstOrDefault(p => p.maChucVu == tb_macv.Text);
            DialogResult dialogResult = MessageBox.Show("Do you want to add this position?", "Warning", MessageBoxButtons.YesNo);
            if (tb_tencv.Text == "")
            {
                MessageBox.Show("Please enter the position!");
            }
            else if (dialogResult == DialogResult.Yes)
            {
                chucVu chucVu = new chucVu();
                {
                    chucVu.tenCV = tb_tencv.Text;
                }
                qLchucVuServices.addChucVu(chucVu);
                load();
            }
            else
            {

            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_chucVu == null)
            {
                MessageBox.Show("Please select a position to update!");
            }
            else
            {
                if (_chucVu.tenCV == tb_tencv.Text || (_chucVu.tenCV != tb_tencv.Text && qLchucVuServices.GetchucVuFromDB().FirstOrDefault(x => x.tenCV == tb_tencv.Text) == null))
                {
                    _chucVu.tenCV = tb_tencv.Text;
                    qLchucVuServices.UpdateChucVu(_chucVu);
                    MessageBox.Show("Updated successful");
                    load();
                    tb_tencv.Text = "";
                }
                else
                {
                    MessageBox.Show("Position already exists");
                }
            }
        }
        public void Rs()
        {
            tb_tencv.Text = "";
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}

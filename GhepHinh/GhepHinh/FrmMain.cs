using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using GhepHinh.Properties;
namespace GhepHinh
{
    public partial class FrmMain : Form
    {
        music m;
        private int _soHang;
        private int _soCot;
        private int _viTriHangOTrong;
        private int _viTriCotOTrong;
        private bool _isStart;
        private int a, b, c;
        Timer _tmDongHo;
        DateTime _thoiGianGoc;
        PictureBox[,] _listPB;
        Image _anh;

        public FrmMain()
        {
            InitializeComponent();
            _isStart = false;
            m = new music();
            m.PlayMusic();
        }

        private void CatAnh(Image anh)
        {
            _anh = anh;
            _listPB = new PictureBox[_soHang, _soCot];
            for (int i = 0; i < _soHang; i++)
            {
                for (int j = 0; j < _soCot; j++)
                {
                    if (i == _soHang - 1 && j == _soCot - 1)
                        break;

                    int chieuRongAnh = pnGame.Width / _soCot;
                    int chieuCaoAnh = pnGame.Height / _soHang;
                    PictureBox pb = new PictureBox();
                    pb.BorderStyle = BorderStyle.Fixed3D;
                    pb.Size = new Size(chieuRongAnh, chieuCaoAnh);
                    pb.Location = LayViTri(i,j);
                    pb.Image = CropImage(anh, new Rectangle(j * chieuRongAnh, i * chieuCaoAnh, chieuRongAnh, chieuCaoAnh));
                    pb.Tag = string.Format("{0}|{1}",i,j);
                    pb.Click += Pb_Click;

                    pnGame.Controls.Add(pb);
                    _listPB[i, j] = pb;
                }
            }

            _viTriHangOTrong = _soHang - 1;
            _viTriCotOTrong = _soCot - 1;
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (!_isStart) return;
            if (GanVoiOTrong(pb.Location))
            {
                int viTriCotOTrongMoi = LayViTriCot(pb.Location);
                int viTriHangOTrongMoi = LayViTriHang(pb.Location);
                if (pb.Location.X == LayViTri(_viTriHangOTrong, _viTriCotOTrong).X)
                {
                    if (pb.Location.Y < LayViTri(_viTriHangOTrong, _viTriCotOTrong).Y)  // Dịch ô xuống dưới
                    {
                        while (pb.Location.Y != LayViTri(_viTriHangOTrong, _viTriCotOTrong).Y)
                        {
                            pb.Location = new Point(pb.Location.X, pb.Location.Y + 1);
                            Delay(1000);
                        }
                        _viTriHangOTrong--;
                        //_listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong + 1, _viTriCotOTrong);
                        _listPB[_viTriHangOTrong + 1, _viTriCotOTrong] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
                        _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
                    }
                    else // Dịch ô lên trên
                    {
                        while (pb.Location.Y != LayViTri(_viTriHangOTrong, _viTriCotOTrong).Y)  
                        {
                            pb.Location = new Point(pb.Location.X, pb.Location.Y - 1);
                            Delay(1000);
                        }
                        _viTriHangOTrong++;
                        //_listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong - 1, _viTriCotOTrong);
                        _listPB[_viTriHangOTrong - 1, _viTriCotOTrong] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
                        _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
                    }
                }
                else if (pb.Location.Y == LayViTri(_viTriHangOTrong, _viTriCotOTrong).Y)
                {
                    if (pb.Location.X < LayViTri(_viTriHangOTrong, _viTriCotOTrong).X) // Dịch ô sang phải
                    {
                        while (pb.Location.X != LayViTri(_viTriHangOTrong, _viTriCotOTrong).X)
                        {
                            pb.Location = new Point(pb.Location.X + 1, pb.Location.Y);
                            Delay(1000);
                        }
                        _viTriCotOTrong--;
                        //_listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong, _viTriCotOTrong + 1);
                        _listPB[_viTriHangOTrong, _viTriCotOTrong + 1] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
                        _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
                    }
                    else // Dịch ô sang trái
                    {
                        while (pb.Location.X != LayViTri(_viTriHangOTrong, _viTriCotOTrong).X)
                        {
                            pb.Location = new Point(pb.Location.X - 1, pb.Location.Y);
                            Delay(1000);
                        }
                        _viTriCotOTrong++;
                        //_listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong, _viTriCotOTrong - 1);
                        _listPB[_viTriHangOTrong, _viTriCotOTrong - 1] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
                        _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
                    }
                }

                //pb.Location = LayViTri(_viTriHangOTrong, _viTriCotOTrong);
                //_viTriCotOTrong = viTriCotOTrongMoi;
                //_viTriHangOTrong = viTriHangOTrongMoi;
                tsslStep.Text = (Convert.ToInt32(tsslStep.Text) + 1).ToString();

                if (CheckChienThang())
                {
                    //m.winner();
                    FrmGhiDanh frmGhiDanh = new GhepHinh.FrmGhiDanh(tsslTime.Text, tsslStep.Text);
                    _tmDongHo.Enabled = false;
                    _isStart = false;
                    Win win = new GhepHinh.Win(tsslTime.Text, tsslStep.Text);
                    int chieuRongAnh = pnGame.Width / _soCot;
                    int chieuCaoAnh = pnGame.Height / _soHang;
                    PictureBox pb1 = new PictureBox();
                    pb1.BorderStyle = BorderStyle.Fixed3D;
                    pb1.Size = new Size(chieuRongAnh, chieuCaoAnh);
                    pb1.Location = LayViTri(_soCot - 1, _soHang - 1);
                    pb1.Image = CropImage(_anh, new Rectangle((_soHang - 1) * chieuRongAnh, (_soCot - 1) * chieuCaoAnh, chieuRongAnh, chieuCaoAnh));
                    pb1.Tag = string.Format("{0}|{1}", _soCot - 1, _soHang - 1);
                    pnGame.Controls.Add(pb1);
                    win.ShowDialog();
                    frmGhiDanh.ShowDialog();
                }
            }
        }

        private void Delay(int miliseconds)
        {
            int x = 0;
            while (x < miliseconds)
            {
                x++;
            }
        }

        private bool CheckChienThang()
        {
            for (int i = 0; i < _soHang; i++)
            {
                for (int j = 0; j < _soCot; j++)
                {
                    if (_listPB[i, j] != null)
                    {
                        if (_listPB[i, j].Tag.ToString() != string.Format("{0}|{1}", LayViTriHang(_listPB[i, j].Location), LayViTriCot(_listPB[i, j].Location)))
                        {
                            return false;
                        }
                    } 
                }
            }
            timer1.Stop();
            return true;
        }

        private int LayViTriCot(Point viTri)
        {
            return (int)(viTri.X / (pnGame.Size.Width / _soCot)); 
        }

        private int LayViTriHang(Point viTri)
        {
            return (int)(viTri.Y / (pnGame.Size.Width / _soHang));
        }

        private Point LayViTri(int _viTriHang, int _viTriCot)
        {
            return new Point( _viTriCot * (pnGame.Size.Width / _soCot), _viTriHang * (pnGame.Size.Width / _soHang));
        }

        private bool GanVoiOTrong(Point viTri)
        {
            if ((LayViTriCot(viTri) == _viTriCotOTrong + 1 && LayViTriHang(viTri) == _viTriHangOTrong) || 
                (LayViTriCot(viTri) == _viTriCotOTrong - 1 && LayViTriHang(viTri) == _viTriHangOTrong) ||
                (LayViTriHang(viTri) == _viTriHangOTrong + 1 && LayViTriCot(viTri) == _viTriCotOTrong) || 
                (LayViTriHang(viTri) == _viTriHangOTrong - 1 && LayViTriCot(viTri) == _viTriCotOTrong))
                return true;
            else
                return false;
        }

        private Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you exit?","Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isStart)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "*.jpg|*.jpg";
                ofd.Multiselect = false;
                ofd.Title = "Hãy lựa chọn file ảnh";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pnGame.Controls.Clear();
                    Image anhNho = Image.FromFile(ofd.FileName).GetThumbnailImage(pnGame.Size.Width, pnGame.Size.Height, null, new IntPtr());

                    pbRefPic.Image = anhNho;
                    _soHang = Settings.Default.SoHangCot;
                    _soCot = Settings.Default.SoHangCot;
                    tsslStep.Text = "0";
                    tsslTime.Text = "00:00:00";
                    CatAnh(anhNho);
                }
            }
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (pnGame.Controls.Count != 0 && !_isStart)
            {
                _isStart = true;
                _tmDongHo = new Timer();
               _tmDongHo.Interval=100;
                _tmDongHo.Tick += _tmDongHo_Tick;
                _tmDongHo.Enabled = true;
            }
            timer1.Start();
            btnStart.Visible = false;
            btnStop.Visible = true;
            btnExit.Visible = true;
        }
        private void _tmDongHo_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = (DateTime.Now - _thoiGianGoc).ToString().Split('.')[0];
        }
        private void XaoTron()
        {
            Random rd = new Random();
            for (int t = 0; t < 1000; t++)
            {
            	if (rd.Next(0,100) %2 == 0) //Dịch ngang
                {
                    if (_viTriCotOTrong == 0)
                    {
                        DichOTrongSangPhai();
                    }
                    else if (_viTriCotOTrong == _soCot - 1)
                    {
                        DichOTrongSangTrai();
                    }
                    else
                    {
                        if (rd.Next(0,100)%2 == 0) //Dịch sang trái
                        {
                            DichOTrongSangTrai();
                        }
                        else //Dịch sang phải
                        {
                            DichOTrongSangPhai();
                        }
                    }
                }
                else //Dịch dọc
                {
                    if (_viTriHangOTrong == 0)
                    {
                        DichOTrongXuongDuoi();
                    }
                    else if (_viTriHangOTrong == _soHang - 1)
                    {
                        DichOTrongLenTren();
                    }
                    else
                    {
                        if (rd.Next(0,100)%2 == 0) //Dịch lên trên
                        {
                            DichOTrongLenTren();
                        }
                        else //Dịch xuống dưới
                        {
                            DichOTrongXuongDuoi();
                        }
                    }
                }
            }
        }


        private void DichOTrongSangTrai()
        {
            _viTriCotOTrong--;
            _listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong, _viTriCotOTrong + 1);
            _listPB[_viTriHangOTrong, _viTriCotOTrong + 1] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
            _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
        }

        private void DichOTrongSangPhai()
        {
            _viTriCotOTrong++;
            _listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong, _viTriCotOTrong - 1);
            _listPB[_viTriHangOTrong, _viTriCotOTrong - 1] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
            _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
        }

        private void DichOTrongLenTren()
        {
            _viTriHangOTrong--;
            _listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong + 1, _viTriCotOTrong);
            _listPB[_viTriHangOTrong + 1, _viTriCotOTrong] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
            _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
        }

        private void DichOTrongXuongDuoi()
        {
            _viTriHangOTrong++;
            _listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong - 1, _viTriCotOTrong);
            _listPB[_viTriHangOTrong - 1, _viTriCotOTrong] = _listPB[_viTriHangOTrong, _viTriCotOTrong];
            _listPB[_viTriHangOTrong, _viTriCotOTrong] = null;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_isStart)
            {
                _tmDongHo.Enabled = false;
                _isStart = false;
                
            }
            timer1.Stop();
            btnStart.Visible = true;
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool drag = false;
        private Point dragCursor, dragForm;

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void lbTitle_MouseMove(object sender, MouseEventArgs e)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
        }

        private void lbTitle_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        
        
        
        void EXITClick(object sender, EventArgs e)
        {
        	 DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", "Exit Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button == EXIT && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }
        
        void PbRefPicClick(object sender, EventArgs e)
        {
        	
        }
        
        void HướngDẫnToolStripMenuItemClick(object sender, EventArgs e)
        {
        	Guide gd = new Guide();
        	gd.Show();
        }
      
        private void FrmMain_Load_1(object sender, EventArgs e)
        {

            for (int i = 1; i <= 180; i++)
            {
                sophut.Items.Add(i);
            }
            sophut.SelectedIndex = 4;
            btnStop.Visible = false;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchChiếnThắngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isStart)
            {
                FrmWinnerList frm = new FrmWinnerList();
                frm.ShowDialog();
            }
        }

        private void hangXCotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isStart)
            {
                FrmSetting frmSetting = new GhepHinh.FrmSetting();
                frmSetting.ShowDialog();
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            a = Int32.Parse(label2.Text); //miligiay
            b = Int32.Parse(label1.Text); //giay
            c = Int32.Parse(label3.Text); //phut
            a--;
            if (a < 0)
            {
                a = 63;
                b--;
                if (b < 0)
                {
                    b = 59;
                    c--;
                }
            }


            if (a < 10)
            {
                label2.Text = "0" + a;
            }
            else
                label2.Text = a + "";
            if (b < 10)
            {
                label1.Text = "0" + b;
            }
            else
                label1.Text = b + "";
            if (c < 10)
            {
                label3.Text = "0" + c;
            }
            else
                label3.Text = c + "";

            if (a == 0 && b == 0 && c == 0)
            {
                timer1.Stop();
                btnStart.Visible = true;
                btnStop.Visible = false;
                btnExit.Visible = false;
                _tmDongHo.Enabled = false;
                _isStart = false;
                MessageBox.Show("Hết giờ");
                

            }
        }
        

        private void Trộn_Click(object sender, EventArgs e)
        {
            XaoTron();
            if (pnGame.Controls.Count != 0 && !_isStart)
            {
                label3.Text = sophut.Text;
                tsslStep.Text = "0";
                tsslTime.Text = "00:00:00";
                _isStart = true;
                _thoiGianGoc = DateTime.Now;
                _tmDongHo = new Timer();
                _tmDongHo.Interval = 100;
                _tmDongHo.Tick += _tmDongHo_Tick;
                _tmDongHo.Enabled = true;
            }
            timer1.Start();
            btnStart.Visible = false;
            btnStop.Visible = true;
            btnExit.Visible = true;
        }
        
    }
}

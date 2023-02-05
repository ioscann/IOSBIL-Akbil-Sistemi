using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Akbil_projesi
{
    public class themeClass : MaterialForm
    {
        public void labelsColorBlack(Form myForm)
        {
            foreach (var item in myForm.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    ((Label)item).ForeColor = Color.Black;
                    ((Label)item).BackColor = Color.Transparent;
                }
            }
        }

        public void labelsColorWhite(Form myForm)
        {
            foreach (var item in myForm.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    ((Label)item).ForeColor = Color.White;
                    ((Label)item).BackColor = Color.Transparent;
                }
            }
        }

        public void themeDark(MaterialForm myForm)
        {
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(myForm);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey100, Accent.Blue100, TextShade.WHITE);
            //ilk primary üst lısımların rengini belirler
            //ikinci primary pencere özellikleri olan kısmın rengini belirler
            //ücüncüyü bende bilmiyom ama bir işe yarıyor işte
            //Accent kutucukların iç rengini belirler
            //textshade form araçlarının yazı rengini belirler  
        }

        public void themeLight(MaterialForm myForm)
        {
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(myForm);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
        }
    }
}

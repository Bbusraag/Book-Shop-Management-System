using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement1.modelBook
{
    class ClassYardım
    {

        string ilkyardım;
        string ikinciyardım;
        string ücüncüyardım;
        string dördüncüyardım;
        string besinciyardım;
        string altıncıyardım;
        string yedinciyardım;
        string sekizinciyardım;
        string dokuzuncuyardım;
        string onuncuyardım;
        string onbirinciyardım;




        public string İLKYARDIM { get => ilkyardım; set => ilkyardım = value; }
        public string İKİNCİYARDIM { get => ikinciyardım; set => ikinciyardım = value; }
        public string ÜÇÜNCÜYARDIM { get => ücüncüyardım; set => ücüncüyardım = value; }
        public string DÖRDÜNCÜYARDIM { get => dördüncüyardım; set => dördüncüyardım = value; }
        public string BEŞİNCİYARDIM { get => besinciyardım; set => besinciyardım = value; }
        public string ALTINCIYARDIM { get => altıncıyardım; set => altıncıyardım = value; }
        public string YEDİNCİYARDIM { get => yedinciyardım; set => yedinciyardım = value; }
        public string SEKİZİNCİYARDIM { get => sekizinciyardım; set => sekizinciyardım = value; }
        public string DOKUZUNCYARDIM { get => dokuzuncuyardım; set => dokuzuncuyardım = value; }
        public string ONUNCUYARDIM { get => onuncuyardım; set => onuncuyardım = value; }
        public string ONBİRİNCİYARDIM { get => onbirinciyardım; set => onbirinciyardım = value; }



        public DataTable GetYardım()
        {
            string query = "SELECT*FROM YARDIM";
            return DataAccess.ExecuteQuery(query);

        }
        public DataTable GetYardımbyBİRİNCİYARDIM()
        {
            string query = "SELECT*FROM BİRİNCİ YARDIM";
            return DataAccess.ExecuteQuery(query);

            }
    }
}


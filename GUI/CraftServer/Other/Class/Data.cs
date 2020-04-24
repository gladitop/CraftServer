using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftServer.Other.Class
{
    static public class Data
    {
        #region Параметры

        public const string PathSave = "Settings.json";//Файл сохранение

        #endregion

        #region Переменные

        static public Settings Settings { get; set; }//Настройки

        #endregion
    }
}

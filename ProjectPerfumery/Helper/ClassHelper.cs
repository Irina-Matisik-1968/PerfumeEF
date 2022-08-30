using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerfumery.Helper
{
    //Класс с глобальными величинами
    public class ClassHelper
    {
        public static int RoleId { get; set; }  //Номер роли
        public static SystemRoles CurrentRole {get;set;}    //Название текущей роли
        public static string FullName { get; set; } //Полное имя пользователя

    }
    //Названия ролей
    public enum SystemRoles { Гость_неавторизированный =0, Администратор, Менеджер, Гость_авторизированный };
}

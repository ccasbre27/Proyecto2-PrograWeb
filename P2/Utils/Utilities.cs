﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace P2.Utils
{
    public class Utilities
    {
      
        public static User LoggedUser
        {
            get
            {
                return HttpContext.Current.Session["UserLogged"] as User;
            }
            set
            {
                HttpContext.Current.Session["UserLogged"] = value;
            }
        }


        public Utilities()
        {
            
        }

        public static T MapClass<T>(Object myobj)
        {
            Type objectType = myobj.GetType();
            Type target = typeof(T);
            var x = Activator.CreateInstance(target, false);
            var z = from source in objectType.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            var d = from source in target.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            List<MemberInfo> members = d.Where(memberInfo => d.Select(c => c.Name)
               .ToList().Contains(memberInfo.Name)).ToList();
            PropertyInfo propertyInfo;
            object value;
            foreach (var memberInfo in members)
            {

                propertyInfo = typeof(T).GetProperty(memberInfo.Name);
                if (myobj.GetType().GetProperty(memberInfo.Name) != null && propertyInfo.Name.ToUpper() == myobj.GetType().GetProperty(memberInfo.Name).Name.ToUpper())
                {
                    value = myobj.GetType().GetProperty(memberInfo.Name).GetValue(myobj, null);

                    propertyInfo.SetValue(x, ChangeType(value, propertyInfo.PropertyType), null);

                }
            }
            return (T)x;
        }

        private static object ChangeType(object value, Type conversion)
        {
            var t = conversion;

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null || value.ToString() == "")
                {
                    return null;
                }

                t = Nullable.GetUnderlyingType(t);
            }

            return Convert.ChangeType(value, t);
        }

        public static string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
            {
                output.Append(hashedBytes[i].ToString("x2").ToLower());
            }

            return output.ToString();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;//应用于序列化对象
using System.Collections;//应用于数组空间
using System.IO;//应用于文件操作
using System.Runtime.Serialization;
using System.Reflection;//应用于反射属性
using System.ComponentModel;
using AGaugeApp;

namespace 智能平台总控端
{
    public class ObjectXML
    {
        
        /// <summary>
        /// 处理结果信息列表
        /// </summary>
        public static ArrayList disposeInfo = new ArrayList();
        /// <summary>
        /// 操作完成之后是否显示结果信息
        /// </summary>
        public static bool messageInfo = false;

        
        #region 写入XML文件


        /// <summary>
        /// 序列化Form对象的所有控件 并保存至XML文件
        /// </summary>
        /// <param name="form"></param>
        public static string WriteXML(Control form)
        {
            DateTime dt = DateTime.Now;
            disposeInfo.Clear();
            ArrayList array = new ArrayList();//[form.Controls.Count];
            int _sum = 0;
            dgControl(form, ref array,0,ref _sum);
            SoapFormatter formatter = new SoapFormatter();//IFormatter
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, array);
            string text = System.Text.Encoding.UTF8.GetString(stream.GetBuffer());
            stream.Close();
            return text;
        }

        #endregion


        #region 读取XML文件

        public static void ReadXML(Control form,string sstr)
        {
            DateTime dt = DateTime.Now;
            SoapFormatter formatter = new SoapFormatter();//IFormatter
            byte[] dd = Encoding.UTF8.GetBytes(sstr);
            MemoryStream streama = new MemoryStream(dd);             //convert stream 2 string
            streama.Position = 0;
            ArrayList array = new ArrayList();
            array = (ArrayList)formatter.Deserialize(streama);
            streama.Close();

            disposeInfo.Clear();
            //---------------------------------------------------------------------
            int _sum = 0;
            dgControl(form, ref array, 1, ref _sum);

            /*            
            //循环窗体上的所有控件对象
            foreach (Control obj in form.Controls)
            {
                UnListStream(obj, (Object[])array[_sum++]);//(Object[])array.GetValue(_sum++));
            }
            */

            //---------------------------------------------------------------------
            disposeInfo.Add("********************" + "\r\n");
            disposeInfo.Add("读取对象总数:" + array.Count.ToString() + "\r\n");
            disposeInfo.Add("读取时间:" + (DateTime.Now - dt).ToString() + "\r\n");



            //显示信息
            if (messageInfo)
            {
                string str = string.Empty;
                for (int i = 0; i < disposeInfo.Count; i++)
                    str += disposeInfo[i].ToString();
                MessageBox.Show(str, "结果报告");
            }
        }

        #endregion


        #region 序列化对象



        /// <summary>
        /// 处理单个对象的所有属性 并写入一个Object类型
        /// 
        /// 其它说明
        /// 1).值为null 则序列化为null值
        /// 2).不能序列化的属性 则跳过不保存
        /// 3).属性无效和不能反序列化 不保存(Cursor公用控件属性 ColumnCount,RowCount,FirstDisplayedScrollingRowIndexFirstDisplayedScrollingColumnIndex, DataGridView类型控件 AutoScroll 工具条控件)
        /// 4).属性只读 不保存
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Object ListStream(Object obj)
        {

            

            Type type = obj.GetType();//取得控件类型

            //根据类型获取属性
            PropertyInfo[] proInfo = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);// | BindingFlags.NonPublic


            Object[] _value = new Object[proInfo.GetLength(0)];

            int _sum = 0;//当前属性位置
            int _unList = 0;//不能序列化数量
            int _readOnly = 0;//只读数量
            int _noAttrib = 0;//无效属性与不能反序列化属性数量

            //_value.SetValue(obj.ToString(), _sum++);//此处可以增加保存控件的标识


            //此循环中 处理对象类型中的所有属性 但排除三种可能性
            //1).值为null 则序列化为null值
            //2).不能序列化的属性 则跳过不保存
            //3).特殊类型 不能序列化或反序列化 跳过不保存
            foreach (PropertyInfo qq in proInfo)
            {
                //Console.WriteLine("{0}{1}", "     " + sum.ToString() + "  ", qq + "   " + qq.GetValue(obj, null));                



                //4).判断属性是否无效 则不保存//(qq.Name == "Item")
                if (TypeDescriptor.GetProperties(obj)[qq.Name] == null ||
                    qq.Name == "Cursor" ||
                    qq.Name == "ColumnCount" ||
                    qq.Name == "RowCount" ||
                    qq.Name == "FirstDisplayedScrollingRowIndex" ||
                    qq.Name == "FirstDisplayedScrollingColumnIndex" ||
                    qq.Name == "AutoScroll")
                {
                    _noAttrib++;
                    continue;
                }
                //5).判断是否是只读属性 则不保存   
                AttributeCollection attributes = TypeDescriptor.GetProperties(obj)[qq.Name].Attributes;
                ReadOnlyAttribute myAttribute = (ReadOnlyAttribute)attributes[typeof(ReadOnlyAttribute)];

                if (!myAttribute.IsReadOnly)
                {

                    //1).判断为null值
                    if (qq.GetValue(obj, null) == null)
                    {
                        _value.SetValue(null, _sum++);
                    }
                    else if (qq.GetValue(obj, null).GetType().IsSerializable)//判断此属性结构是否可序列化
                    {
                        //3).特殊类型属性处理 不能解析属性
                        //if (qq.GetValue(obj, null) is Cursor)
                        //{
                            //_value.SetValue("不能解析属性", sum++);  
                        //}
                        //else
                            _value.SetValue(qq.GetValue(obj, null), _sum++);//正常处理
                    }
                    //2).不能序列化属性
                    else
                    {
                        //_value.SetValue("未序列化属性", sum++);
                        _unList++;
                    }

                }else
                    _readOnly++;


            }
            

            //写入信息
            disposeInfo.Add("对象:" + obj.ToString() + "\r\n");
            disposeInfo.Add("对象属性总数:" + _value.Length.ToString() + "\t");
            disposeInfo.Add("已序列化属性数量:" + _sum.ToString() + "\t");
            disposeInfo.Add("不能序列化属性数量:" + _unList.ToString() + "\t");
            disposeInfo.Add("只读属性数量:" + _readOnly.ToString() + "\t");
            disposeInfo.Add("无效属性与不能反序列化属性数量:" + _noAttrib.ToString() + "\t");

            disposeInfo.Add("\r\n");



            return _value;//返回已序列数组




            /*
                //如何能够判断出所有关联的属性值
                IFormatter formatter = new SoapFormatter();
                FileStream stream = new FileStream("myFileName.xml", FileMode.Create, FileAccess.Write, FileShare.None);//FileMode.Append, FileAccess.Write, FileShare.None
                formatter.Serialize(stream, _value);
                stream.Close();
            */


        }

        #endregion


        #region 反序列化对象

        /// <summary>
        /// 反序列化函数
        /// </summary>
        /// <param name="obj">原对象 将反序列化对象的数据改写原对象</param>
        /// <param name="_value">要反序列化的对象</param>
        public static void UnListStream(Object obj, Object[] _value)
        {



            //取得控件类型
            Type type = obj.GetType();

            //根据类型获取属性
            PropertyInfo[] proInfo = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);// | BindingFlags.NonPublic



            int _sum = 0;
            int _unList = 0;//不能序列化数量
            int _readOnly = 0;//只读数量
            int _noAttrib = 0;//无效属性数量

            //此循环中 处理对象类型中的所有属性 但排除三种可能性
            //1).值为null 则序列化为null值
            //2).不能序列化的属性 则跳过不保存
            //3).特殊类型 不能序列化或反序列化 跳过不保存
            foreach (PropertyInfo qq in proInfo)
            {


                //Console.WriteLine("{0}{1}", "     " + _sum.ToString() + "  ", qq + "   " + qq.GetValue(obj, null));

                //判断属性是否无效
                if (TypeDescriptor.GetProperties(obj)[qq.Name] == null ||
                    qq.Name == "Cursor" ||
                    qq.Name == "ColumnCount" ||
                    qq.Name == "RowCount" ||
                    qq.Name == "FirstDisplayedScrollingRowIndex" ||
                    qq.Name == "FirstDisplayedScrollingColumnIndex" ||
                    qq.Name == "AutoScroll")
                {
                    _noAttrib++;
                    continue;
                }
                //首先判断是否是只读属性
                AttributeCollection attributes = TypeDescriptor.GetProperties(obj)[qq.Name].Attributes;
                ReadOnlyAttribute myAttribute = (ReadOnlyAttribute)attributes[typeof(ReadOnlyAttribute)];
                if (!myAttribute.IsReadOnly)
                {
                    //1).判断为null值
                    if (qq.GetValue(obj, null) == null)
                    {
                        qq.SetValue(obj, _value[_sum++], null);

                        //判断此属性结构是否可序列化
                    }
                    else if (qq.GetValue(obj, null).GetType().IsSerializable)
                    {
                        //3).特殊类型属性处理 不能解析属性
                        //if (qq.GetValue(obj, null) is Cursor)
                        //{
                            //_value.SetValue("None", sum++);
                        
                            //正常处理
                        //}
                        //else                        
                            qq.SetValue(obj, _value[_sum++], null);
                        

                    }
                    //2).不能序列化属性
                    else
                    {
                        //_value.SetValue("未序列化属性", sum++);
                        _unList++;
                    }


                }else
                    _readOnly++;

            }



            //写入信息
            disposeInfo.Add("对象:" + obj.ToString() + "\r\n");
            disposeInfo.Add("读取属性总数:" + _value.Length .ToString() + "\t");
            disposeInfo.Add("已反序列化属性数量:" + _sum.ToString() + "\t");
            disposeInfo.Add("不能反序列化属性数量:" + _unList.ToString() + "\t");
            disposeInfo.Add("只读属性数量:" + _readOnly.ToString() + "\t");
            disposeInfo.Add("无效属性与不能反序列化属性数量:" + _noAttrib.ToString() + "\t");

            disposeInfo.Add("\r\n");


        }



        #endregion


        #region 其它函数

        /// <summary>
        /// 递归所有有控件集合的对象
        /// </summary>
        /// <param name="obj">要操作的对象</param>
        /// <param name="array">保存数据的数组</param>
        /// <param name="bs">0).表示序列化操作 1).表示反序列化操作</param>
        /// <param name="_sum">反序列化操作时的当前位置</param>
        private static void dgControl(Control obj, ref ArrayList array, int bs, ref int _sum )
        {
            if (bs == 0)
            {
                //循环窗体上的所有控件对象
                foreach (Control o in obj.Controls)
                {

                    //array.SetValue((Array)ListStream(o), _sum++);//调用序列化单个对象处理函数 并将返回值存入一个数组中
                    array.Add(ListStream(o));

                    if (o.Controls.Count > 0)
                        dgControl(o, ref array, 0, ref _sum);
                }

            }
            else
            {


                foreach (Control o in obj.Controls)
                {

                    UnListStream(o, (Object[])array[_sum++]);

                    if (o.Controls.Count > 0)
                        dgControl(o, ref array, 1, ref _sum);
                }


            }


        }
        #endregion
    }
}

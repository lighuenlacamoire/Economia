using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace ESIDIFCommon.Tools
{
    public static class PropertySpecifiedExtensions
    {
        private const string SPECIFIED_SUFFIX = "Specified";

        /// <summary>
        /// Bind the <see cref="INotifyPropertyChanged.PropertyChanged"/> handler to automatically set any xxxSpecified fields when a property is changed.  "Lazy" via reflection.
        /// </summary>
        /// <param name="entity">the entity to bind the autospecify event to</param>
        /// <param name="specifiedSuffix">optionally specify a suffix for the Specified property to set as true on changes</param>
        /// <param name="specifiedPrefix">optionally specify a prefix for the Specified property to set as true on changes</param>
        public static void Autospecify(this INotifyPropertyChanged entity, string specifiedSuffix = SPECIFIED_SUFFIX, string specifiedPrefix = null)
        {
            entity.PropertyChanged += (me, e) =>
            {
                foreach (var pi in me.GetType().GetProperties().Where(o => o.Name == specifiedPrefix + e.PropertyName + specifiedSuffix))
                {
                    pi.SetValue(me, true, BindingFlags.SetField | BindingFlags.SetProperty, null, null, null);
                }
            };
        }

        /// <summary>
        /// Create a new entity and <see cref="Autospecify"/> its properties when changed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="specifiedSuffix"></param>
        /// <param name="specifiedPrefix"></param>
        /// <returns></returns>
        public static T Create<T>(string specifiedSuffix = SPECIFIED_SUFFIX, string specifiedPrefix = null) where T : INotifyPropertyChanged, new()
        {
            var ret = new T();
            ret.Autospecify(specifiedSuffix, specifiedPrefix);
            return ret;
        }
    }

    public static class GenericObject<T> where T : new()
    {
        public static T GenericMethod(bool inicio = false)
        {
            var source = new T();
            var sourceProps = source.GetType().GetProperties().ToList();
            Type t = typeof(GenericObject<>);

            foreach (var sourceProp in sourceProps)
            {
                if (sourceProp.PropertyType.IsClass && !sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    var c = Activator.CreateInstance(sourceProp.PropertyType);
                    Type genericType = t.MakeGenericType(new System.Type[] { sourceProp.PropertyType });
                    MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                    //MethodInfo crear = genericType.GetMethod("Create");

                    //creo asigno e invoko
                    //c = crear.Invoke(null, new object[] { SPECIFIED_SUFFIX, null });
                    c = m.Invoke(null, new object[] { true });
                    sourceProp.SetValue(source, c, null);
                }
                else if (sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    IList souObj = sourceProp.GetValue(source, null) as IList;
                    string desName = sourceProp.PropertyType.FullName;
                    desName = desName.Replace("[]", "");
                    Type type = Type.GetType(desName);

                    if (type != null)
                    {
                        var cArray = Array.CreateInstance(type, new int[] { 0 });
                        var c = Activator.CreateInstance(Type.GetType(desName));
                        Type genericType = t.MakeGenericType(new System.Type[] { Type.GetType(desName) });
                        MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                        //MethodInfo crear = genericType.GetMethod("Create");

                        //creo asigno e invoko
                        c = m.Invoke(null, new object[] { true });
                        cArray.SetValue(c, 0);
                        sourceProp.SetValue(source, cArray, null);
                    }

                }
            }
            return source;
        }
    }

    public static class GenericClass<T> where T : INotifyPropertyChanged, new()
    {
        private const string SPECIFIED_SUFFIX = "Specified";

        public static T GenericMethod(bool inicio = false)
        {
            var source = PropertySpecifiedExtensions.Create<T>();
            var sourceProps = source.GetType().GetProperties().ToList();
            Type t = typeof(GenericClass<>);

            foreach (var sourceProp in sourceProps)
            {
                if (sourceProp.PropertyType.IsClass && !sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    var c = Activator.CreateInstance(sourceProp.PropertyType);
                    Type genericType = t.MakeGenericType(new System.Type[] { sourceProp.PropertyType });
                    MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                    //MethodInfo crear = genericType.GetMethod("Create");

                    //creo asigno e invoko
                    //c = crear.Invoke(null, new object[] { SPECIFIED_SUFFIX, null });
                    c = m.Invoke(null, new object[] { true });
                    sourceProp.SetValue(source, c, null);
                }
                else if (sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    IList souObj = sourceProp.GetValue(source, null) as IList;
                    string desName = sourceProp.PropertyType.FullName;
                    desName = desName.Replace("[]", "");
                    var cArray = Array.CreateInstance(Type.GetType(desName), new int[] { 0 });
                    var c = Activator.CreateInstance(Type.GetType(desName));
                    Type genericType = t.MakeGenericType(new System.Type[] { Type.GetType(desName) });
                    MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                    //MethodInfo crear = genericType.GetMethod("Create");

                    //creo asigno e invoko
                    c = m.Invoke(null, new object[] { true });
                    cArray.SetValue(c, 0);
                    sourceProp.SetValue(source, cArray, null);

                }
            }
            return source;
        }
    }

    public sealed class XmlAnything<T> : IXmlSerializable
    {
        public XmlAnything() { }
        public XmlAnything(T t) { this.Value = t; }
        public T Value { get; set; }

        public void WriteXml(XmlWriter writer)
        {
            if (Value == null)
            {
                writer.WriteAttributeString("type", "null");
                return;
            }
            Type type = this.Value.GetType();
            XmlSerializer serializer = new XmlSerializer(type);
            //writer.WriteAttributeString("type", type.AssemblyQualifiedName);
            serializer.Serialize(writer, this.Value);
        }

        public void ReadXml(XmlReader reader)
        {
            if (!reader.HasAttributes)
                throw new FormatException("expected a type attribute!");
            string type = reader.GetAttribute("type");
            reader.Read(); // consume the value
            if (type == "null")
                return;// leave T at default value
            XmlSerializer serializer = new XmlSerializer(Type.GetType(type));
            this.Value = (T)serializer.Deserialize(reader);
            reader.ReadEndElement();
        }

        public XmlSchema GetSchema() { return (null); }
    }
}

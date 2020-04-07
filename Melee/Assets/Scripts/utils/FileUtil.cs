using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

/**
*fileUtil是一个工具，定义其为一个类，有很多的静态方法可以写数据到文件，也可以从文件中读取数据成某种数据类型。
*0.根据不同的平台获取不同的文件路径。
*1.序列化数据对象为string 然后将string写入到xml文件，读取xml文件反并序列化到数据类型。
*2.写入数据对象到json文件，读取json文件成为想要的数据类型。
*3.按行写入数据到文本文件，按行读取文本文件。
*/

public class FileUtil : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {

    }

    void Start()
    {

    }
    //写入某种类型的数据序列化到xml中
    //参数:type，数据类型。因为要写成一个工具方法，所以type可以传入任何类型,此时type的数据类型必须是泛型数据。
    //泛型数据,需要引入c#中的system命名空间
    public static void writeDataToXml(System.Type type, object data, string fileName)
    {
        MemoryStream mStream = new MemoryStream();// 为什么要创建这个玩意。

        XmlSerializer xs = new XmlSerializer(type);
        XmlTextWriter xTextWriter = new XmlTextWriter(mStream, Encoding.UTF8);

        xs.Serialize(xTextWriter, data);
        mStream = (MemoryStream)xTextWriter.BaseStream;

        string objData = UTF8ByteArrayToString(mStream.ToArray());
        createXml(fileName, objData);
        // return UTF8ByteArrayToString(mStream.ToArray());
    }
    public static void createXml(string fileName, string dataString)
    {
        StreamWriter writer;
        // todo 如果不存在该文件则，创建，如果存在则写入。
        writer = File.CreateText(fileName);
        writer.Write(dataString);
        writer.Close();
    }
    public static string UTF8ByteArrayToString(byte[] bytes)
    {
        UTF8Encoding encoding = new UTF8Encoding();
        return encoding.GetString(bytes);
    }
    public static byte[] stringToUTF8ByteArray(string dataString)
    {
        UTF8Encoding encoding = new UTF8Encoding();
        return encoding.GetBytes(dataString);
    }
    public static string getDataPath()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            return Application.persistentDataPath;
        }
        else
            return Application.dataPath;
    }
    //从xml文件中读取数据，反序列化为某类型数据。
    //参数:type, 数据的类型。
    public static object readDataFromXml(string fileName, System.Type type)
    {
        if (File.Exists(fileName))
        {
            StreamReader reader = File.OpenText(fileName);
            string dataString = reader.ReadToEnd();
            reader.Close();

            byte[] byteData = stringToUTF8ByteArray(dataString);
            XmlSerializer xs = new XmlSerializer(type);
            MemoryStream mStream = new MemoryStream(byteData);

            return xs.Deserialize(mStream);

        }
        else
        {
            Debug.Log("_fileName not exis");
            return null;
        }

    }

}
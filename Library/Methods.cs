using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml;

using System.Windows.Forms;
using eAnbar.Forms;
using eAnbar.Forms.Operations;

namespace eAnbar.Library
{
    public class Methods
    {
        public static Import Import = new Import();
        public static Edit Edit = new Edit();
        public static Move Move = new Move();
        public static ItemsList ItemsList = new ItemsList();

        public bool CheckForInternetConnection()
                {
                    try
                    {
                        using (var client = new WebClient())
                        {
                            using (var stream = client.OpenRead("http://cbar.az"))
                            {
                                return true;
                            }
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }

        public string RemoteXmlLoad(string date)
        {
            string szURL = "http://cbar.az/currencies/" + date + ".xml";

            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;
            string bodyText = "";
            Stream responseStream = null;
            Byte[] RecvBytes = new byte[byte.MaxValue];
            Int32 bytes;
            try
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(szURL);
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                responseStream = httpResponse.GetResponseStream();
                while (true)
                {
                    bytes = responseStream.Read(RecvBytes, 0, RecvBytes.Length);
                    if (bytes <= 0) break;
                    bodyText += System.Text.Encoding.UTF8.GetString(RecvBytes, 0, bytes);
                }
            }
            catch (Exception e)
            {
                bodyText = "HTTP Error:" + e.Message;
            }
            finally
            {
                httpRequest = null;
                httpResponse = null;
                if (responseStream != null)
                {
                    responseStream.Dispose();
                    responseStream = null;
                }
            }
            return bodyText;
        }

        public void AllowOnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}

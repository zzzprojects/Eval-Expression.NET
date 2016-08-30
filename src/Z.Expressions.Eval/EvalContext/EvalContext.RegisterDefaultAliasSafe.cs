// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Registers default alias (Extension Methods, Names, Static Members, Types and Values).</summary>
        public void RegisterDefaultAliasSafe()
        {
            // Extension Methods
            RegisterExtensionMethod(typeof (Enumerable));
            RegisterExtensionMethod(typeof (Queryable));

            // Static Members
            RegisterStaticMember(typeof (Math));

            // Types

            // Fundamentals
            {
                // System (Primitive Type)
                RegisterType(typeof (bool));
                RegisterType(typeof (byte));
                RegisterType(typeof (char));
                RegisterType(typeof (decimal));
                RegisterType(typeof (double));
                RegisterType(typeof (int));
                RegisterType(typeof (float));
                RegisterType(typeof (long));
                RegisterType(typeof (object));
                RegisterType(typeof (sbyte));
                RegisterType(typeof (short));
                RegisterType(typeof (string));
                RegisterType(typeof (uint));
                RegisterType(typeof (ulong));
                RegisterType(typeof (ushort));

                // System (Exception)
                RegisterType(typeof (Exception));
                RegisterType(typeof (OverflowException));

                // System (Misc)
                RegisterType(typeof (Array));
                RegisterType(typeof (DateTime));
                RegisterType(typeof (DateTimeOffset));
                RegisterType(typeof (Delegate));
                RegisterType(typeof (Enum));
                RegisterType(typeof (EventArgs));
                RegisterType(typeof (ExpandoObject));
                RegisterType(typeof (Math));
                RegisterType(typeof (TimeZoneInfo));
                RegisterType(typeof (Type));

                // System.Collections
                RegisterType(typeof (ArrayList));
                RegisterType(typeof (Hashtable));
                RegisterType(typeof (IEnumerable));

                // System.Collections.Generic
                RegisterType(typeof (Dictionary<,>));
                RegisterType(typeof (HashSet<>));
                RegisterType(typeof (IEnumerable<>));
                RegisterType(typeof (List<>));
                RegisterType(typeof (Queue<>));
                RegisterType(typeof (Stack<>));

                // System.ComponentModel
                RegisterType(typeof (Component));
                RegisterType(typeof (TypeConverter));

                // System.Diagnostics

                // System.Diagnostics.Eventing

                // System.Diagnostics.Eventing.Reader

                // System.Diagnostics.PerformanceData

                // System.Globalization

                // System.IO

                // System.IO.Compression
                //RegisterType(typeof (GZipStream));

                // System.IO.IsolatedStorage
                //RegisterType(typeof (IsolatedStorage));

                // System.IO.Pipes
                //RegisterType(typeof (AnonymousPipeClientStream));
                //RegisterType(typeof (AnonymousPipeServerStream));
                //RegisterType(typeof (NamedPipeClientStream));
                //RegisterType(typeof (NamedPipeServerStream));
                //RegisterType(typeof (PipeSecurity));
                //RegisterType(typeof (PipeStream));

                // System.IO.Ports
                //RegisterType(typeof (SerialPort));

                // System.Linq
                RegisterType(typeof (IQueryable<>));
                RegisterType(typeof (Queryable));

                // System.Linq.Expressions
                RegisterType(typeof (Expression<>));
                RegisterType(typeof (Expression));

                // System.Reflection
                //RegisterType(typeof (Assembly));
                //RegisterType(typeof (ConstructorInfo));
                //RegisterType(typeof (FieldInfo));
                //RegisterType(typeof (MemberInfo));
                //RegisterType(typeof (MethodInfo));
                //RegisterType(typeof (PropertyInfo));

                // System.Reflection.Emit
                //RegisterType(typeof (AssemblyBuilder));
                //RegisterType(typeof (MethodBuilder));
                //RegisterType(typeof (TypeBuilder));

                // System.Resources
                //RegisterType(typeof (ResourceManager));

                // System.Security
                //RegisterType(typeof (SecureString));
                //RegisterType(typeof (SecurityManager));

                // System.Security.AccessControl
                //RegisterType(typeof (AccessRule));
                //RegisterType(typeof (FileSecurity));
                //RegisterType(typeof (ObjectSecurity));

                // System.Security.Cryptography
                //RegisterType(typeof (ECDsaCng));
                //RegisterType(typeof (SHA1));
                //RegisterType(typeof (TripleDES));

                // System.Security.Cruptography.X509Certificates
                //RegisterType(typeof (X509Store));

                // System.Security.Principal
                //RegisterType(typeof (WindowsIdentity));

                // System.Text
                RegisterType(typeof (Encoding));
                RegisterType(typeof (StringBuilder));

                // System.Text.RegularExpressions
                RegisterType(typeof (Regex));

                // System.Threading
                //RegisterType(typeof (ReaderWriterLockSlim));
                //RegisterType(typeof (Semaphore));
                //RegisterType(typeof (Thread));
                //RegisterType(typeof (WaitHandle));
            }

            // Communications and Workflow
            {
                // System.Net
                //RegisterType(typeof (Dns));
                //RegisterType(typeof (FtpWebRequest));
                //RegisterType(typeof (HttpListener));
                //RegisterType(typeof (HttpWebRequest));
                //RegisterType(typeof (WebClient));

                // System.Net.Mail
                //RegisterType(typeof (MailMessage));
                //RegisterType(typeof (SmtpClient));

                // System.Net.NetworkInformation
                //RegisterType(typeof (NetworkInterface));
                //RegisterType(typeof (NetworkChange));
                //RegisterType(typeof (Ping));

                // System.Net.Security
                //RegisterType(typeof (NegotiateStream));
                //RegisterType(typeof (SslStream));

                // System.Net.Sockets
                //RegisterType(typeof (NetworkStream));
                //RegisterType(typeof (Socket));
                //RegisterType(typeof (TcpClient));
                //RegisterType(typeof (TcpListener));
                //RegisterType(typeof (UdpClient));
            }

            // DATA, XML, and LINQ
            {
                // System.Data
                //RegisterType(typeof (DataColumn));
                //RegisterType(typeof (DataRow));
                //RegisterType(typeof (DataSet));
                //RegisterType(typeof (DataTable));
                //RegisterType(typeof (DataView));

                // System.Data.Common
                //RegisterType(typeof (DbCommand));
                //RegisterType(typeof (DbConnection));
                //RegisterType(typeof (DbDataAdapter));
                //RegisterType(typeof (DbDataReader));
                //RegisterType(typeof (DbProviderFactory));

                // System.Data.SqlClient
                //RegisterType(typeof (SqlCommand));
                //RegisterType(typeof (SqlConnection));
                //RegisterType(typeof (SqlDataAdapter));
                //RegisterType(typeof (SqlDataReader));

                // System.XML
                //RegisterType(typeof (XmlAttribute));
                //RegisterType(typeof (XmlDocument));
                //RegisterType(typeof (XmlElement));
                //RegisterType(typeof (XmlNode));
                //RegisterType(typeof (XmlReader));
                //RegisterType(typeof (XmlWriter));

                // System.Xml.Linq
                //RegisterType(typeof (XAttribute));
                //RegisterType(typeof (XDocument));
                //RegisterType(typeof (XElement));
                //RegisterType(typeof (XName));
                //RegisterType(typeof (XNamespace));
                //RegisterType(typeof (XNode));
                //RegisterType(typeof (XText));

                // System.Xml.Schema
                //RegisterType(typeof (XmlSchema));
                //RegisterType(typeof (XmlSchemaSet));
                //RegisterType(typeof (XmlSchemaValidator));

                // System.Xml.Serialization
                //RegisterType(typeof (XmlSerializer));

                // System.Xml.XPath
                //RegisterType(typeof (XPathDocument));
                //RegisterType(typeof (XPathExpression));
                //RegisterType(typeof (XPathNavigator));

                // System.Xml.Xsl
                //RegisterType(typeof (XslCompiledTransform));
                //RegisterType(typeof (XsltArgumentList));
            }

            // .NET Framework 4 and Extensions
            {
                // Core
                //RegisterType(typeof (SortedSet<>));
                //RegisterType(typeof (ParallelEnumerable));
                //RegisterType(typeof (LazyInitializer));
                //RegisterType(typeof (SpinLock));
                //RegisterType(typeof (Parallel));

                // System.Tuple
                RegisterType(typeof (Tuple));
                RegisterType(typeof (Tuple<>));
                RegisterType(typeof (Tuple<,>));
                RegisterType(typeof (Tuple<,,>));
                RegisterType(typeof (Tuple<,,,>));
                RegisterType(typeof (Tuple<,,,,>));
                RegisterType(typeof (Tuple<,,,,,>));
                RegisterType(typeof (Tuple<,,,,,,>));
                RegisterType(typeof (Tuple<,,,,,,,>));
            }

            // NEW
            //RegisterType(typeof (CommandType));
            RegisterType(typeof (Match));

            // Library
            //RegisterType(typeof (EvalManager));
            //RegisterType(typeof (Eval));
        }
    }
}
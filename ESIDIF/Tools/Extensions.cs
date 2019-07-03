using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIDIF.Tools
{
    public class Extensions
    {
        public async Task<string> FormatRequest(HttpRequest request)
        {
            var body = request.Body;

            //This line allows us to set the reader for the request back at the beginning of its stream.
            //request.EnableRewind();

            //We now need to read the request stream.  First, we create a new byte[] with the same length as the request stream...
            var buffer = new byte[Convert.ToInt32(request.ContentLength)];

            //...Then we copy the entire request stream into the new buffer.
            await body.ReadAsync(buffer, 0, buffer.Length);

            //We convert the byte[] into a string using UTF8 encoding...
            var bodyAsText = Encoding.UTF8.GetString(buffer);



            //..and finally, assign the read body back to the request body, which is allowed because of EnableRewind()
            //request.Body = body;

            return bodyAsText;

            //return $"{request.Scheme} {request.Host}{request.Path} {request.QueryString} {bodyAsText}";
        }

        public string FormatRequest2(Stream cuerpo)
        {
            
            string requestXML = string.Empty;

            //var cuerpo = request.Body;

            using (var reader = new StreamReader(cuerpo))
            {
                var body = reader.ReadToEnd();

                // Do something

                cuerpo.Seek(0, SeekOrigin.Begin);

                body = reader.ReadToEnd();

                requestXML = body;
            }

            //Stream newStream = new MemoryStream();

            //CopyStream(body, newStream);

            //if (newStream != null)
            //{

            //    newStream.Position = 0;
            //    var reader = new StreamReader(newStream);

            //    requestXML = reader.ReadToEnd();

            //}
            return requestXML;

        }

        private static void CopyStream(Stream fromStream, Stream toStream)
        {
            try
            {
                var sr = new StreamReader(fromStream);
                var sw = new StreamWriter(toStream);

                sw.WriteLine(sr.ReadToEnd());
                sw.Flush();
            }
            catch (Exception ex)
            {
                var message = "CopyStream fallo: " + ex.Message;
            }

        }
        public async Task<string> FormatResponse(HttpResponse response)
        {
            //We need to read the response stream from the beginning...
            response.Body.Seek(0, SeekOrigin.Begin);

            //...and copy it into a string
            string text = await new StreamReader(response.Body).ReadToEndAsync();

            //We need to reset the reader for the response so that the client can read it.
            response.Body.Seek(0, SeekOrigin.Begin);

            //Return the string for the response, including the status code (e.g. 200, 404, 401, etc.)
            return $"{response.StatusCode}: {text}";
        }
    }
}

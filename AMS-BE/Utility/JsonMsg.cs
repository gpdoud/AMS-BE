using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utility {
	public class JsonMsg {
		public static JsonMsg Ok = new JsonMsg("Ok", "Success!");
		public static JsonMsg Error = new JsonMsg("Error", "The process resulted in an error!");
		public static JsonMsg Fail = new JsonMsg("Fail", "The process resulted in a failure!");
		public static JsonMsg Warn = new JsonMsg("Warning", "The process resulted in a warning.");

		public string Result { get; set; }
		public string Message { get; set; }

		public JsonMsg(string result, string message) {
			this.Result = result;
			this.Message = message;
		}
		public JsonMsg() : this("Ok", "Success!") {
		}
	}
}
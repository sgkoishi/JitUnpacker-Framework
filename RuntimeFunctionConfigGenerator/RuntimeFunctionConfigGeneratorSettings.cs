using System;
using System.IO;

namespace JitTools {
	public sealed class RuntimeFunctionConfigGeneratorSettings {
		private string _symbolsDirectory;

		[Option("-d", IsRequired = false, DefaultValue = "", Description = "The directory of symbols")]
		internal string SymbolsDirectoryCliSetter {
			set => SymbolsDirectory = value;
		}

		public string SymbolsDirectory {
			get => _symbolsDirectory;
			set => _symbolsDirectory = string.IsNullOrEmpty(value) ? null : Path.GetFullPath(value);
		}
	}
}

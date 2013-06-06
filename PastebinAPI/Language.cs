using System;
using System.Linq;
using System.Collections.Generic;

namespace PastebinAPI
{
    public class Language
    {
        #region Languages
        // ReSharper disable InconsistentNaming
        public static Language _4CS { get { return Languages["4cs"]; } }
        public static Language _6502ACMECrossAssembler { get { return Languages["6502acme"]; } }
        public static Language _6502KickAssembler { get { return Languages["6502kickass"]; } }
        public static Language _6502TASM64TASS { get { return Languages["6502tasm"]; } }
        public static Language ABAP { get { return Languages["abap"]; } }
        public static Language ActionScript { get { return Languages["actionscript"]; } }
        public static Language ActionScript3 { get { return Languages["actionscript3"]; } }
        public static Language Ada { get { return Languages["ada"]; } }
        public static Language ALGOL68 { get { return Languages["algol68"]; } }
        public static Language ApacheLog { get { return Languages["apache"]; } }
        public static Language AppleScript { get { return Languages["applescript"]; } }
        public static Language APTSources { get { return Languages["apt_sources"]; } }
        public static Language ARM { get { return Languages["arm"]; } }
        public static Language ASM { get { return Languages["asm"]; } }
        public static Language ASP { get { return Languages["asp"]; } }
        public static Language Asymptote { get { return Languages["asymptote"]; } }
        public static Language autoconf { get { return Languages["autoconf"]; } }
        public static Language Autohotkey { get { return Languages["autohotkey"]; } }
        public static Language AutoIt { get { return Languages["autoit"]; } }
        public static Language Avisynth { get { return Languages["avisynth"]; } }
        public static Language Awk { get { return Languages["awk"]; } }
        public static Language BASCOMAVR { get { return Languages["bascomavr"]; } }
        public static Language Bash { get { return Languages["bash"]; } }
        public static Language Basic4GL { get { return Languages["basic4gl"]; } }
        public static Language BibTeX { get { return Languages["bibtex"]; } }
        public static Language BlitzBasic { get { return Languages["blitzbasic"]; } }
        public static Language BNF { get { return Languages["bnf"]; } }
        public static Language BOO { get { return Languages["boo"]; } }
        public static Language BrainFuck { get { return Languages["bf"]; } }
        public static Language C { get { return Languages["c"]; } }
        public static Language CforMacs { get { return Languages["c_mac"]; } }
        public static Language CIntermediateLanguage { get { return Languages["cil"]; } }
        public static Language CSharp { get { return Languages["csharp"]; } }
        public static Language CPlusPlus { get { return Languages["cpp"]; } }
        public static Language CPlusPlusQT { get { return Languages["cpp-qt"]; } }
        public static Language CLoadrunner { get { return Languages["c_loadrunner"]; } }
        public static Language CADDCL { get { return Languages["caddcl"]; } }
        public static Language CADLisp { get { return Languages["cadlisp"]; } }
        public static Language CFDG { get { return Languages["cfdg"]; } }
        public static Language ChaiScript { get { return Languages["chaiscript"]; } }
        public static Language Clojure { get { return Languages["clojure"]; } }
        public static Language CloneC { get { return Languages["klonec"]; } }
        public static Language CloneCPlusPlus { get { return Languages["klonecpp"]; } }
        public static Language CMake { get { return Languages["cmake"]; } }
        public static Language COBOL { get { return Languages["cobol"]; } }
        public static Language CoffeeScript { get { return Languages["coffeescript"]; } }
        public static Language ColdFusion { get { return Languages["cfm"]; } }
        public static Language CSS { get { return Languages["css"]; } }
        public static Language Cuesheet { get { return Languages["cuesheet"]; } }
        public static Language D { get { return Languages["d"]; } }
        public static Language DCL { get { return Languages["dcl"]; } }
        public static Language DCPU16 { get { return Languages["dcpu16"]; } }
        public static Language DCS { get { return Languages["dcs"]; } }
        public static Language Delphi { get { return Languages["delphi"]; } }
        public static Language Oxygene { get { return Languages["oxygene"]; } }
        public static Language Diff { get { return Languages["diff"]; } }
        public static Language DIV { get { return Languages["div"]; } }
        public static Language DOS { get { return Languages["dos"]; } }
        public static Language DOT { get { return Languages["dot"]; } }
        public static Language E { get { return Languages["e"]; } }
        public static Language ECMAScript { get { return Languages["ecmascript"]; } }
        public static Language Eiffel { get { return Languages["eiffel"]; } }
        public static Language Email { get { return Languages["email"]; } }
        public static Language EPC { get { return Languages["epc"]; } }
        public static Language Erlang { get { return Languages["erlang"]; } }
        public static Language FSharp { get { return Languages["fsharp"]; } }
        public static Language Falcon { get { return Languages["falcon"]; } }
        public static Language FOLanguage { get { return Languages["fo"]; } }
        public static Language FormulaOne { get { return Languages["f1"]; } }
        public static Language Fortran { get { return Languages["fortran"]; } }
        public static Language FreeBasic { get { return Languages["freebasic"]; } }
        public static Language FreeSWITCH { get { return Languages["freeswitch"]; } }
        public static Language GAMBAS { get { return Languages["gambas"]; } }
        public static Language GameMaker { get { return Languages["gml"]; } }
        public static Language GDB { get { return Languages["gdb"]; } }
        public static Language Genero { get { return Languages["genero"]; } }
        public static Language Genie { get { return Languages["genie"]; } }
        public static Language GetText { get { return Languages["gettext"]; } }
        public static Language Go { get { return Languages["go"]; } }
        public static Language Groovy { get { return Languages["groovy"]; } }
        public static Language GwBasic { get { return Languages["gwbasic"]; } }
        public static Language Haskell { get { return Languages["haskell"]; } }
        public static Language Haxe { get { return Languages["haxe"]; } }
        public static Language HicEst { get { return Languages["hicest"]; } }
        public static Language HQ9Plus { get { return Languages["hq9plus"]; } }
        public static Language HTML { get { return Languages["html4strict"]; } }
        public static Language HTML5 { get { return Languages["html5"]; } }
        public static Language Icon { get { return Languages["icon"]; } }
        public static Language IDL { get { return Languages["idl"]; } }
        public static Language INIfile { get { return Languages["ini"]; } }
        public static Language InnoScript { get { return Languages["inno"]; } }
        public static Language INTERCAL { get { return Languages["intercal"]; } }
        public static Language IO { get { return Languages["io"]; } }
        public static Language J { get { return Languages["j"]; } }
        public static Language Java { get { return Languages["java"]; } }
        public static Language Java5 { get { return Languages["java5"]; } }
        public static Language JavaScript { get { return Languages["javascript"]; } }
        public static Language jQuery { get { return Languages["jquery"]; } }
        public static Language KiXtart { get { return Languages["kixtart"]; } }
        public static Language Latex { get { return Languages["latex"]; } }
        public static Language LDIF { get { return Languages["ldif"]; } }
        public static Language LibertyBASIC { get { return Languages["lb"]; } }
        public static Language LindenScripting { get { return Languages["lsl2"]; } }
        public static Language Lisp { get { return Languages["lisp"]; } }
        public static Language LLVM { get { return Languages["llvm"]; } }
        public static Language LocoBasic { get { return Languages["locobasic"]; } }
        public static Language Logtalk { get { return Languages["logtalk"]; } }
        public static Language LOLCode { get { return Languages["lolcode"]; } }
        public static Language LotusFormulas { get { return Languages["lotusformulas"]; } }
        public static Language LotusScript { get { return Languages["lotusscript"]; } }
        public static Language LScript { get { return Languages["lscript"]; } }
        public static Language Lua { get { return Languages["lua"]; } }
        public static Language M68000Assembler { get { return Languages["m68k"]; } }
        public static Language MagikSF { get { return Languages["magiksf"]; } }
        public static Language Make { get { return Languages["make"]; } }
        public static Language MapBasic { get { return Languages["mapbasic"]; } }
        public static Language MatLab { get { return Languages["matlab"]; } }
        public static Language mIRC { get { return Languages["mirc"]; } }
        public static Language MIXAssembler { get { return Languages["mmix"]; } }
        public static Language Modula2 { get { return Languages["modula2"]; } }
        public static Language Modula3 { get { return Languages["modula3"]; } }
        public static Language Motorola68000HiSoftDev { get { return Languages["68000devpac"]; } }
        public static Language MPASM { get { return Languages["mpasm"]; } }
        public static Language MXML { get { return Languages["mxml"]; } }
        public static Language MySQL { get { return Languages["mysql"]; } }
        public static Language Nagios { get { return Languages["nagios"]; } }
        public static Language newLISP { get { return Languages["newlisp"]; } }
        public static Language None { get { return Languages["text"]; } }
        public static Language NullSoftInstaller { get { return Languages["nsis"]; } }
        public static Language Oberon2 { get { return Languages["oberon2"]; } }
        public static Language ObjeckProgrammingLangua { get { return Languages["objeck"]; } }
        public static Language ObjectiveC { get { return Languages["objc"]; } }
        public static Language OCalmBrief { get { return Languages["ocaml-brief"]; } }
        public static Language OCaml { get { return Languages["ocaml"]; } }
        public static Language Octave { get { return Languages["octave"]; } }
        public static Language OpenBSDPACKETFILTER { get { return Languages["pf"]; } }
        public static Language OpenGLShading { get { return Languages["glsl"]; } }
        public static Language OpenofficeBASIC { get { return Languages["oobas"]; } }
        public static Language Oracle11 { get { return Languages["oracle11"]; } }
        public static Language Oracle8 { get { return Languages["oracle8"]; } }
        public static Language Oz { get { return Languages["oz"]; } }
        public static Language ParaSail { get { return Languages["parasail"]; } }
        public static Language PARIGP { get { return Languages["parigp"]; } }
        public static Language Pascal { get { return Languages["pascal"]; } }
        public static Language PAWN { get { return Languages["pawn"]; } }
        public static Language PCRE { get { return Languages["pcre"]; } }
        public static Language Per { get { return Languages["per"]; } }
        public static Language Perl { get { return Languages["perl"]; } }
        public static Language Perl6 { get { return Languages["perl6"]; } }
        public static Language PHP { get { return Languages["php"]; } }
        public static Language PHPBrief { get { return Languages["php-brief"]; } }
        public static Language Pic16 { get { return Languages["pic16"]; } }
        public static Language Pike { get { return Languages["pike"]; } }
        public static Language PixelBender { get { return Languages["pixelbender"]; } }
        public static Language PLSQL { get { return Languages["plsql"]; } }
        public static Language PostgreSQL { get { return Languages["postgresql"]; } }
        public static Language POVRay { get { return Languages["povray"]; } }
        public static Language PowerShell { get { return Languages["powershell"]; } }
        public static Language PowerBuilder { get { return Languages["powerbuilder"]; } }
        public static Language ProFTPd { get { return Languages["proftpd"]; } }
        public static Language Progress { get { return Languages["progress"]; } }
        public static Language Prolog { get { return Languages["prolog"]; } }
        public static Language Properties { get { return Languages["properties"]; } }
        public static Language ProvideX { get { return Languages["providex"]; } }
        public static Language PureBasic { get { return Languages["purebasic"]; } }
        public static Language PyCon { get { return Languages["pycon"]; } }
        public static Language Python { get { return Languages["python"]; } }
        public static Language PythonforS60 { get { return Languages["pys60"]; } }
        public static Language qkdbplus { get { return Languages["q"]; } }
        public static Language QBasic { get { return Languages["qbasic"]; } }
        public static Language R { get { return Languages["rsplus"]; } }
        public static Language Rails { get { return Languages["rails"]; } }
        public static Language REBOL { get { return Languages["rebol"]; } }
        public static Language REG { get { return Languages["reg"]; } }
        public static Language Rexx { get { return Languages["rexx"]; } }
        public static Language Robots { get { return Languages["robots"]; } }
        public static Language RPMSpec { get { return Languages["rpmspec"]; } }
        public static Language Ruby { get { return Languages["ruby"]; } }
        public static Language RubyGnuplot { get { return Languages["gnuplot"]; } }
        public static Language SAS { get { return Languages["sas"]; } }
        public static Language Scala { get { return Languages["scala"]; } }
        public static Language Scheme { get { return Languages["scheme"]; } }
        public static Language Scilab { get { return Languages["scilab"]; } }
        public static Language SdlBasic { get { return Languages["sdlbasic"]; } }
        public static Language Smalltalk { get { return Languages["smalltalk"]; } }
        public static Language Smarty { get { return Languages["smarty"]; } }
        public static Language SPARK { get { return Languages["spark"]; } }
        public static Language SPARQL { get { return Languages["sparql"]; } }
        public static Language SQL { get { return Languages["sql"]; } }
        public static Language StoneScript { get { return Languages["stonescript"]; } }
        public static Language SystemVerilog { get { return Languages["systemverilog"]; } }
        public static Language TSQL { get { return Languages["tsql"]; } }
        public static Language TCL { get { return Languages["tcl"]; } }
        public static Language TeraTerm { get { return Languages["teraterm"]; } }
        public static Language thinBasic { get { return Languages["thinbasic"]; } }
        public static Language TypoScript { get { return Languages["typoscript"]; } }
        public static Language Unicon { get { return Languages["unicon"]; } }
        public static Language UnrealScript { get { return Languages["uscript"]; } }
        public static Language UPC { get { return Languages["ups"]; } }
        public static Language Urbi { get { return Languages["urbi"]; } }
        public static Language Vala { get { return Languages["vala"]; } }
        public static Language VBNET { get { return Languages["vbnet"]; } }
        public static Language Vedit { get { return Languages["vedit"]; } }
        public static Language VeriLog { get { return Languages["verilog"]; } }
        public static Language VHDL { get { return Languages["vhdl"]; } }
        public static Language VIM { get { return Languages["vim"]; } }
        public static Language VisualProLog { get { return Languages["visualprolog"]; } }
        public static Language VisualBasic { get { return Languages["vb"]; } }
        public static Language VisualFoxPro { get { return Languages["visualfoxpro"]; } }
        public static Language WhiteSpace { get { return Languages["whitespace"]; } }
        public static Language WHOIS { get { return Languages["whois"]; } }
        public static Language Winbatch { get { return Languages["winbatch"]; } }
        public static Language XBasic { get { return Languages["xbasic"]; } }
        public static Language XML { get { return Languages["xml"]; } }
        public static Language XorgConfig { get { return Languages["xorg_conf"]; } }
        public static Language XPP { get { return Languages["xpp"]; } }
        public static Language YAML { get { return Languages["yaml"]; } }
        public static Language Z80Assembler { get { return Languages["z80"]; } }
        public static Language ZXBasic { get { return Languages["zxbasic"]; } }
        // ReSharper restore InconsistentNaming
        #endregion
        public static Language Default { get { return None; } }
        public static IEnumerable<Language> All { get { return Languages.Values; } }

        private static readonly Dictionary<string, Language> Languages;
        static Language()
        {
            Languages = (new[] { "4cs",
                                    "6502acme",
                                    "6502kickass",
                                    "6502tasm",
                                    "abap",
                                    "actionscript",
                                    "actionscript3",
                                    "ada",
                                    "algol68",
                                    "apache",
                                    "applescript",
                                    "apt_sources",
                                    "arm",
                                    "asm",
                                    "asp",
                                    "asymptote",
                                    "autoconf",
                                    "autohotkey",
                                    "autoit",
                                    "avisynth",
                                    "awk",
                                    "bascomavr",
                                    "bash",
                                    "basic4gl",
                                    "bibtex",
                                    "blitzbasic",
                                    "bnf",
                                    "boo",
                                    "bf",
                                    "c",
                                    "c_mac",
                                    "cil",
                                    "csharp",
                                    "cpp",
                                    "cpp-qt",
                                    "c_loadrunner",
                                    "caddcl",
                                    "cadlisp",
                                    "cfdg",
                                    "chaiscript",
                                    "clojure",
                                    "klonec",
                                    "klonecpp",
                                    "cmake",
                                    "cobol",
                                    "coffeescript",
                                    "cfm",
                                    "css",
                                    "cuesheet",
                                    "d",
                                    "dcl",
                                    "dcpu16",
                                    "dcs",
                                    "delphi",
                                    "oxygene",
                                    "diff",
                                    "div",
                                    "dos",
                                    "dot",
                                    "e",
                                    "ecmascript",
                                    "eiffel",
                                    "email",
                                    "epc",
                                    "erlang",
                                    "fsharp",
                                    "falcon",
                                    "fo",
                                    "f1",
                                    "fortran",
                                    "freebasic",
                                    "freeswitch",
                                    "gambas",
                                    "gml",
                                    "gdb",
                                    "genero",
                                    "genie",
                                    "gettext",
                                    "go",
                                    "groovy",
                                    "gwbasic",
                                    "haskell",
                                    "haxe",
                                    "hicest",
                                    "hq9plus",
                                    "html4strict",
                                    "html5",
                                    "icon",
                                    "idl",
                                    "ini",
                                    "inno",
                                    "intercal",
                                    "io",
                                    "j",
                                    "java",
                                    "java5",
                                    "javascript",
                                    "jquery",
                                    "kixtart",
                                    "latex",
                                    "ldif",
                                    "lb",
                                    "lsl2",
                                    "lisp",
                                    "llvm",
                                    "locobasic",
                                    "logtalk",
                                    "lolcode",
                                    "lotusformulas",
                                    "lotusscript",
                                    "lscript",
                                    "lua",
                                    "m68k",
                                    "magiksf",
                                    "make",
                                    "mapbasic",
                                    "matlab",
                                    "mirc",
                                    "mmix",
                                    "modula2",
                                    "modula3",
                                    "68000devpac",
                                    "mpasm",
                                    "mxml",
                                    "mysql",
                                    "nagios",
                                    "newlisp",
                                    "text",
                                    "nsis",
                                    "oberon2",
                                    "objeck",
                                    "objc",
                                    "ocaml-brief",
                                    "ocaml",
                                    "octave",
                                    "pf",
                                    "glsl",
                                    "oobas",
                                    "oracle11",
                                    "oracle8",
                                    "oz",
                                    "parasail",
                                    "parigp",
                                    "pascal",
                                    "pawn",
                                    "pcre",
                                    "per",
                                    "perl",
                                    "perl6",
                                    "php",
                                    "php-brief",
                                    "pic16",
                                    "pike",
                                    "pixelbender",
                                    "plsql",
                                    "postgresql",
                                    "povray",
                                    "powershell",
                                    "powerbuilder",
                                    "proftpd",
                                    "progress",
                                    "prolog",
                                    "properties",
                                    "providex",
                                    "purebasic",
                                    "pycon",
                                    "python",
                                    "pys60",
                                    "q",
                                    "qbasic",
                                    "rsplus",
                                    "rails",
                                    "rebol",
                                    "reg",
                                    "rexx",
                                    "robots",
                                    "rpmspec",
                                    "ruby",
                                    "gnuplot",
                                    "sas",
                                    "scala",
                                    "scheme",
                                    "scilab",
                                    "sdlbasic",
                                    "smalltalk",
                                    "smarty",
                                    "spark",
                                    "sparql",
                                    "sql",
                                    "stonescript",
                                    "systemverilog",
                                    "tsql",
                                    "tcl",
                                    "teraterm",
                                    "thinbasic",
                                    "typoscript",
                                    "unicon",
                                    "uscript",
                                    "ups",
                                    "urbi",
                                    "vala",
                                    "vbnet",
                                    "vedit",
                                    "verilog",
                                    "vhdl",
                                    "vim",
                                    "visualprolog",
                                    "vb",
                                    "visualfoxpro",
                                    "whitespace",
                                    "whois",
                                    "winbatch",
                                    "xbasic",
                                    "xml",
                                    "xorg_conf",
                                    "xpp",
                                    "yaml",
                                    "z80",
                                    "zxbasic" }).ToDictionary(s => s, s => new Language(s));
        }

        public static Language Parse(string s)
        {
            Language result;
            if (s == null)
                throw new ArgumentNullException("s");
            if (TryParse(s, out result) == false)
                throw new FormatException(string.Format("Format: {0} is not supported", s));
            return result;
        }

        public static bool TryParse(string s, out Language result)
        {
            result = Default;
            if (s == null || Languages.ContainsKey(s) == false)
                return false;
            result = Languages[s];
            return true;
        }

        private readonly string value;

        private Language(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace PastebinAPI
{
    public class PasteFormat
    {
        #region Formats
        // ReSharper disable InconsistentNaming
        public static PasteFormat _4CS { get { return PasteFormats["4cs"]; } }
        public static PasteFormat _6502ACMECrossAssembler { get { return PasteFormats["6502acme"]; } }
        public static PasteFormat _6502KickAssembler { get { return PasteFormats["6502kickass"]; } }
        public static PasteFormat _6502TASM64TASS { get { return PasteFormats["6502tasm"]; } }
        public static PasteFormat ABAP { get { return PasteFormats["abap"]; } }
        public static PasteFormat ActionScript { get { return PasteFormats["actionscript"]; } }
        public static PasteFormat ActionScript3 { get { return PasteFormats["actionscript3"]; } }
        public static PasteFormat Ada { get { return PasteFormats["ada"]; } }
        public static PasteFormat ALGOL68 { get { return PasteFormats["algol68"]; } }
        public static PasteFormat ApacheLog { get { return PasteFormats["apache"]; } }
        public static PasteFormat AppleScript { get { return PasteFormats["applescript"]; } }
        public static PasteFormat APTSources { get { return PasteFormats["apt_sources"]; } }
        public static PasteFormat ARM { get { return PasteFormats["arm"]; } }
        public static PasteFormat ASM { get { return PasteFormats["asm"]; } }
        public static PasteFormat ASP { get { return PasteFormats["asp"]; } }
        public static PasteFormat Asymptote { get { return PasteFormats["asymptote"]; } }
        public static PasteFormat autoconf { get { return PasteFormats["autoconf"]; } }
        public static PasteFormat Autohotkey { get { return PasteFormats["autohotkey"]; } }
        public static PasteFormat AutoIt { get { return PasteFormats["autoit"]; } }
        public static PasteFormat Avisynth { get { return PasteFormats["avisynth"]; } }
        public static PasteFormat Awk { get { return PasteFormats["awk"]; } }
        public static PasteFormat BASCOMAVR { get { return PasteFormats["bascomavr"]; } }
        public static PasteFormat Bash { get { return PasteFormats["bash"]; } }
        public static PasteFormat Basic4GL { get { return PasteFormats["basic4gl"]; } }
        public static PasteFormat BibTeX { get { return PasteFormats["bibtex"]; } }
        public static PasteFormat BlitzBasic { get { return PasteFormats["blitzbasic"]; } }
        public static PasteFormat BNF { get { return PasteFormats["bnf"]; } }
        public static PasteFormat BOO { get { return PasteFormats["boo"]; } }
        public static PasteFormat BrainFuck { get { return PasteFormats["bf"]; } }
        public static PasteFormat C { get { return PasteFormats["c"]; } }
        public static PasteFormat CforMacs { get { return PasteFormats["c_mac"]; } }
        public static PasteFormat CIntermediateLanguage { get { return PasteFormats["cil"]; } }
        public static PasteFormat CSharp { get { return PasteFormats["csharp"]; } }
        public static PasteFormat CPlusPlus { get { return PasteFormats["cpp"]; } }
        public static PasteFormat CPlusPlusQT { get { return PasteFormats["cpp-qt"]; } }
        public static PasteFormat CLoadrunner { get { return PasteFormats["c_loadrunner"]; } }
        public static PasteFormat CADDCL { get { return PasteFormats["caddcl"]; } }
        public static PasteFormat CADLisp { get { return PasteFormats["cadlisp"]; } }
        public static PasteFormat CFDG { get { return PasteFormats["cfdg"]; } }
        public static PasteFormat ChaiScript { get { return PasteFormats["chaiscript"]; } }
        public static PasteFormat Clojure { get { return PasteFormats["clojure"]; } }
        public static PasteFormat CloneC { get { return PasteFormats["klonec"]; } }
        public static PasteFormat CloneCPlusPlus { get { return PasteFormats["klonecpp"]; } }
        public static PasteFormat CMake { get { return PasteFormats["cmake"]; } }
        public static PasteFormat COBOL { get { return PasteFormats["cobol"]; } }
        public static PasteFormat CoffeeScript { get { return PasteFormats["coffeescript"]; } }
        public static PasteFormat ColdFusion { get { return PasteFormats["cfm"]; } }
        public static PasteFormat CSS { get { return PasteFormats["css"]; } }
        public static PasteFormat Cuesheet { get { return PasteFormats["cuesheet"]; } }
        public static PasteFormat D { get { return PasteFormats["d"]; } }
        public static PasteFormat DCL { get { return PasteFormats["dcl"]; } }
        public static PasteFormat DCPU16 { get { return PasteFormats["dcpu16"]; } }
        public static PasteFormat DCS { get { return PasteFormats["dcs"]; } }
        public static PasteFormat Delphi { get { return PasteFormats["delphi"]; } }
        public static PasteFormat Oxygene { get { return PasteFormats["oxygene"]; } }
        public static PasteFormat Diff { get { return PasteFormats["diff"]; } }
        public static PasteFormat DIV { get { return PasteFormats["div"]; } }
        public static PasteFormat DOS { get { return PasteFormats["dos"]; } }
        public static PasteFormat DOT { get { return PasteFormats["dot"]; } }
        public static PasteFormat E { get { return PasteFormats["e"]; } }
        public static PasteFormat ECMAScript { get { return PasteFormats["ecmascript"]; } }
        public static PasteFormat Eiffel { get { return PasteFormats["eiffel"]; } }
        public static PasteFormat Email { get { return PasteFormats["email"]; } }
        public static PasteFormat EPC { get { return PasteFormats["epc"]; } }
        public static PasteFormat Erlang { get { return PasteFormats["erlang"]; } }
        public static PasteFormat FSharp { get { return PasteFormats["fsharp"]; } }
        public static PasteFormat Falcon { get { return PasteFormats["falcon"]; } }
        public static PasteFormat FOLanguage { get { return PasteFormats["fo"]; } }
        public static PasteFormat FormulaOne { get { return PasteFormats["f1"]; } }
        public static PasteFormat Fortran { get { return PasteFormats["fortran"]; } }
        public static PasteFormat FreeBasic { get { return PasteFormats["freebasic"]; } }
        public static PasteFormat FreeSWITCH { get { return PasteFormats["freeswitch"]; } }
        public static PasteFormat GAMBAS { get { return PasteFormats["gambas"]; } }
        public static PasteFormat GameMaker { get { return PasteFormats["gml"]; } }
        public static PasteFormat GDB { get { return PasteFormats["gdb"]; } }
        public static PasteFormat Genero { get { return PasteFormats["genero"]; } }
        public static PasteFormat Genie { get { return PasteFormats["genie"]; } }
        public static PasteFormat GetText { get { return PasteFormats["gettext"]; } }
        public static PasteFormat Go { get { return PasteFormats["go"]; } }
        public static PasteFormat Groovy { get { return PasteFormats["groovy"]; } }
        public static PasteFormat GwBasic { get { return PasteFormats["gwbasic"]; } }
        public static PasteFormat Haskell { get { return PasteFormats["haskell"]; } }
        public static PasteFormat Haxe { get { return PasteFormats["haxe"]; } }
        public static PasteFormat HicEst { get { return PasteFormats["hicest"]; } }
        public static PasteFormat HQ9Plus { get { return PasteFormats["hq9plus"]; } }
        public static PasteFormat HTML { get { return PasteFormats["html4strict"]; } }
        public static PasteFormat HTML5 { get { return PasteFormats["html5"]; } }
        public static PasteFormat Icon { get { return PasteFormats["icon"]; } }
        public static PasteFormat IDL { get { return PasteFormats["idl"]; } }
        public static PasteFormat INIfile { get { return PasteFormats["ini"]; } }
        public static PasteFormat InnoScript { get { return PasteFormats["inno"]; } }
        public static PasteFormat INTERCAL { get { return PasteFormats["intercal"]; } }
        public static PasteFormat IO { get { return PasteFormats["io"]; } }
        public static PasteFormat J { get { return PasteFormats["j"]; } }
        public static PasteFormat Java { get { return PasteFormats["java"]; } }
        public static PasteFormat Java5 { get { return PasteFormats["java5"]; } }
        public static PasteFormat JavaScript { get { return PasteFormats["javascript"]; } }
        public static PasteFormat jQuery { get { return PasteFormats["jquery"]; } }
        public static PasteFormat KiXtart { get { return PasteFormats["kixtart"]; } }
        public static PasteFormat Latex { get { return PasteFormats["latex"]; } }
        public static PasteFormat LDIF { get { return PasteFormats["ldif"]; } }
        public static PasteFormat LibertyBASIC { get { return PasteFormats["lb"]; } }
        public static PasteFormat LindenScripting { get { return PasteFormats["lsl2"]; } }
        public static PasteFormat Lisp { get { return PasteFormats["lisp"]; } }
        public static PasteFormat LLVM { get { return PasteFormats["llvm"]; } }
        public static PasteFormat LocoBasic { get { return PasteFormats["locobasic"]; } }
        public static PasteFormat Logtalk { get { return PasteFormats["logtalk"]; } }
        public static PasteFormat LOLCode { get { return PasteFormats["lolcode"]; } }
        public static PasteFormat LotusFormulas { get { return PasteFormats["lotusformulas"]; } }
        public static PasteFormat LotusScript { get { return PasteFormats["lotusscript"]; } }
        public static PasteFormat LScript { get { return PasteFormats["lscript"]; } }
        public static PasteFormat Lua { get { return PasteFormats["lua"]; } }
        public static PasteFormat M68000Assembler { get { return PasteFormats["m68k"]; } }
        public static PasteFormat MagikSF { get { return PasteFormats["magiksf"]; } }
        public static PasteFormat Make { get { return PasteFormats["make"]; } }
        public static PasteFormat MapBasic { get { return PasteFormats["mapbasic"]; } }
        public static PasteFormat MatLab { get { return PasteFormats["matlab"]; } }
        public static PasteFormat mIRC { get { return PasteFormats["mirc"]; } }
        public static PasteFormat MIXAssembler { get { return PasteFormats["mmix"]; } }
        public static PasteFormat Modula2 { get { return PasteFormats["modula2"]; } }
        public static PasteFormat Modula3 { get { return PasteFormats["modula3"]; } }
        public static PasteFormat Motorola68000HiSoftDev { get { return PasteFormats["68000devpac"]; } }
        public static PasteFormat MPASM { get { return PasteFormats["mpasm"]; } }
        public static PasteFormat MXML { get { return PasteFormats["mxml"]; } }
        public static PasteFormat MySQL { get { return PasteFormats["mysql"]; } }
        public static PasteFormat Nagios { get { return PasteFormats["nagios"]; } }
        public static PasteFormat newLISP { get { return PasteFormats["newlisp"]; } }
        public static PasteFormat None { get { return PasteFormats["text"]; } }
        public static PasteFormat NullSoftInstaller { get { return PasteFormats["nsis"]; } }
        public static PasteFormat Oberon2 { get { return PasteFormats["oberon2"]; } }
        public static PasteFormat ObjeckProgrammingLangua { get { return PasteFormats["objeck"]; } }
        public static PasteFormat ObjectiveC { get { return PasteFormats["objc"]; } }
        public static PasteFormat OCalmBrief { get { return PasteFormats["ocaml-brief"]; } }
        public static PasteFormat OCaml { get { return PasteFormats["ocaml"]; } }
        public static PasteFormat Octave { get { return PasteFormats["octave"]; } }
        public static PasteFormat OpenBSDPACKETFILTER { get { return PasteFormats["pf"]; } }
        public static PasteFormat OpenGLShading { get { return PasteFormats["glsl"]; } }
        public static PasteFormat OpenofficeBASIC { get { return PasteFormats["oobas"]; } }
        public static PasteFormat Oracle11 { get { return PasteFormats["oracle11"]; } }
        public static PasteFormat Oracle8 { get { return PasteFormats["oracle8"]; } }
        public static PasteFormat Oz { get { return PasteFormats["oz"]; } }
        public static PasteFormat ParaSail { get { return PasteFormats["parasail"]; } }
        public static PasteFormat PARIGP { get { return PasteFormats["parigp"]; } }
        public static PasteFormat Pascal { get { return PasteFormats["pascal"]; } }
        public static PasteFormat PAWN { get { return PasteFormats["pawn"]; } }
        public static PasteFormat PCRE { get { return PasteFormats["pcre"]; } }
        public static PasteFormat Per { get { return PasteFormats["per"]; } }
        public static PasteFormat Perl { get { return PasteFormats["perl"]; } }
        public static PasteFormat Perl6 { get { return PasteFormats["perl6"]; } }
        public static PasteFormat PHP { get { return PasteFormats["php"]; } }
        public static PasteFormat PHPBrief { get { return PasteFormats["php-brief"]; } }
        public static PasteFormat Pic16 { get { return PasteFormats["pic16"]; } }
        public static PasteFormat Pike { get { return PasteFormats["pike"]; } }
        public static PasteFormat PixelBender { get { return PasteFormats["pixelbender"]; } }
        public static PasteFormat PLSQL { get { return PasteFormats["plsql"]; } }
        public static PasteFormat PostgreSQL { get { return PasteFormats["postgresql"]; } }
        public static PasteFormat POVRay { get { return PasteFormats["povray"]; } }
        public static PasteFormat PowerShell { get { return PasteFormats["powershell"]; } }
        public static PasteFormat PowerBuilder { get { return PasteFormats["powerbuilder"]; } }
        public static PasteFormat ProFTPd { get { return PasteFormats["proftpd"]; } }
        public static PasteFormat Progress { get { return PasteFormats["progress"]; } }
        public static PasteFormat Prolog { get { return PasteFormats["prolog"]; } }
        public static PasteFormat Properties { get { return PasteFormats["properties"]; } }
        public static PasteFormat ProvideX { get { return PasteFormats["providex"]; } }
        public static PasteFormat PureBasic { get { return PasteFormats["purebasic"]; } }
        public static PasteFormat PyCon { get { return PasteFormats["pycon"]; } }
        public static PasteFormat Python { get { return PasteFormats["python"]; } }
        public static PasteFormat PythonforS60 { get { return PasteFormats["pys60"]; } }
        public static PasteFormat qkdbplus { get { return PasteFormats["q"]; } }
        public static PasteFormat QBasic { get { return PasteFormats["qbasic"]; } }
        public static PasteFormat R { get { return PasteFormats["rsplus"]; } }
        public static PasteFormat Rails { get { return PasteFormats["rails"]; } }
        public static PasteFormat REBOL { get { return PasteFormats["rebol"]; } }
        public static PasteFormat REG { get { return PasteFormats["reg"]; } }
        public static PasteFormat Rexx { get { return PasteFormats["rexx"]; } }
        public static PasteFormat Robots { get { return PasteFormats["robots"]; } }
        public static PasteFormat RPMSpec { get { return PasteFormats["rpmspec"]; } }
        public static PasteFormat Ruby { get { return PasteFormats["ruby"]; } }
        public static PasteFormat RubyGnuplot { get { return PasteFormats["gnuplot"]; } }
        public static PasteFormat SAS { get { return PasteFormats["sas"]; } }
        public static PasteFormat Scala { get { return PasteFormats["scala"]; } }
        public static PasteFormat Scheme { get { return PasteFormats["scheme"]; } }
        public static PasteFormat Scilab { get { return PasteFormats["scilab"]; } }
        public static PasteFormat SdlBasic { get { return PasteFormats["sdlbasic"]; } }
        public static PasteFormat Smalltalk { get { return PasteFormats["smalltalk"]; } }
        public static PasteFormat Smarty { get { return PasteFormats["smarty"]; } }
        public static PasteFormat SPARK { get { return PasteFormats["spark"]; } }
        public static PasteFormat SPARQL { get { return PasteFormats["sparql"]; } }
        public static PasteFormat SQL { get { return PasteFormats["sql"]; } }
        public static PasteFormat StoneScript { get { return PasteFormats["stonescript"]; } }
        public static PasteFormat SystemVerilog { get { return PasteFormats["systemverilog"]; } }
        public static PasteFormat TSQL { get { return PasteFormats["tsql"]; } }
        public static PasteFormat TCL { get { return PasteFormats["tcl"]; } }
        public static PasteFormat TeraTerm { get { return PasteFormats["teraterm"]; } }
        public static PasteFormat thinBasic { get { return PasteFormats["thinbasic"]; } }
        public static PasteFormat TypoScript { get { return PasteFormats["typoscript"]; } }
        public static PasteFormat Unicon { get { return PasteFormats["unicon"]; } }
        public static PasteFormat UnrealScript { get { return PasteFormats["uscript"]; } }
        public static PasteFormat UPC { get { return PasteFormats["ups"]; } }
        public static PasteFormat Urbi { get { return PasteFormats["urbi"]; } }
        public static PasteFormat Vala { get { return PasteFormats["vala"]; } }
        public static PasteFormat VBNET { get { return PasteFormats["vbnet"]; } }
        public static PasteFormat Vedit { get { return PasteFormats["vedit"]; } }
        public static PasteFormat VeriLog { get { return PasteFormats["verilog"]; } }
        public static PasteFormat VHDL { get { return PasteFormats["vhdl"]; } }
        public static PasteFormat VIM { get { return PasteFormats["vim"]; } }
        public static PasteFormat VisualProLog { get { return PasteFormats["visualprolog"]; } }
        public static PasteFormat VisualBasic { get { return PasteFormats["vb"]; } }
        public static PasteFormat VisualFoxPro { get { return PasteFormats["visualfoxpro"]; } }
        public static PasteFormat WhiteSpace { get { return PasteFormats["whitespace"]; } }
        public static PasteFormat WHOIS { get { return PasteFormats["whois"]; } }
        public static PasteFormat Winbatch { get { return PasteFormats["winbatch"]; } }
        public static PasteFormat XBasic { get { return PasteFormats["xbasic"]; } }
        public static PasteFormat XML { get { return PasteFormats["xml"]; } }
        public static PasteFormat XorgConfig { get { return PasteFormats["xorg_conf"]; } }
        public static PasteFormat XPP { get { return PasteFormats["xpp"]; } }
        public static PasteFormat YAML { get { return PasteFormats["yaml"]; } }
        public static PasteFormat Z80Assembler { get { return PasteFormats["z80"]; } }
        public static PasteFormat ZXBasic { get { return PasteFormats["zxbasic"]; } }
        // ReSharper restore InconsistentNaming
        #endregion
        public static PasteFormat Default { get { return None; } }
        public static IEnumerable<PasteFormat> All { get { return PasteFormats.Values; } }

        private static readonly Dictionary<string, PasteFormat> PasteFormats;
        static PasteFormat()
        {
            PasteFormats = (new[] { "4cs",
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
                                    "zxbasic" }).ToDictionary(s => s, s => new PasteFormat(s));
        }

        public static PasteFormat Parse(string s)
        {
            PasteFormat result;
            if (s == null)
                throw new ArgumentNullException("s");
            if (TryParse(s, out result) == false)
                throw new FormatException(string.Format("Format: {0} is not supported", s));
            return result;
        }

        public static bool TryParse(string s, out PasteFormat result)
        {
            result = Default;
            if (s == null || PasteFormats.ContainsKey(s) == false)
                return false;
            result = PasteFormats[s];
            return true;
        }

        private readonly string value;
        private PasteFormat(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}

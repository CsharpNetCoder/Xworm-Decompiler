using System;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x02000036 RID: 54
	public class GeoIP
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x00056F2A File Offset: 0x0005512A
		public GeoIP(MemoryStream mss)
		{
			this.MS = mss;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00056F3C File Offset: 0x0005513C
		public GeoIP(string FileLocation)
		{
			FileStream fileStream = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
			this.MS = new MemoryStream();
			byte[] array = new byte[257];
			while (fileStream.Read(array, 0, array.Length) != 0)
			{
				this.MS.Write(array, 0, array.Length);
			}
			fileStream.Close();
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00056FA0 File Offset: 0x000551A0
		private long ConvertIPAddressToNumber(IPAddress IPA)
		{
			string[] array = Strings.Split(IPA.ToString(), ".", -1, CompareMethod.Binary);
			bool flag = Information.UBound(array, 1) == 3;
			long result;
			if (flag)
			{
				result = checked((long)Math.Round(unchecked(16777216.0 * Conversions.ToDouble(array[0]) + 65536.0 * Conversions.ToDouble(array[1]) + 256.0 * Conversions.ToDouble(array[2]) + Conversions.ToDouble(array[3]))));
			}
			else
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00057024 File Offset: 0x00055224
		private string ConvertIPNumberToAddress(long IPN)
		{
			return string.Concat(new string[]
			{
				Conversions.ToString(Conversion.Int((double)IPN / 16777216.0) % 256.0),
				".",
				Conversions.ToString(Conversion.Int((double)IPN / 65536.0) % 256.0),
				".",
				Conversions.ToString(Conversion.Int((double)IPN / 256.0) % 256.0),
				".",
				Conversions.ToString(Conversion.Int(IPN) % 256L)
			});
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000570D8 File Offset: 0x000552D8
		public static MemoryStream FileToMemory(string FileLocation)
		{
			FileStream fileStream = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[257];
			while (fileStream.Read(array, 0, array.Length) != 0)
			{
				memoryStream.Write(array, 0, array.Length);
			}
			fileStream.Close();
			return memoryStream;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00057130 File Offset: 0x00055330
		public string LookupCountryCode(IPAddress IPA)
		{
			return GeoIP.CountryCode[checked((int)this.SeekCountry(0L, this.ConvertIPAddressToNumber(IPA), 31))];
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0005715C File Offset: 0x0005535C
		public string LookupCountryNump(IPAddress IPA)
		{
			return GeoIP.CountryNump[checked((int)this.SeekCountry(0L, this.ConvertIPAddressToNumber(IPA), 31))];
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00057188 File Offset: 0x00055388
		public string LookupCountryNump(string IPA)
		{
			IPAddress ipa;
			try
			{
				ipa = IPAddress.Parse(IPA);
			}
			catch (FormatException ex)
			{
				return "--";
			}
			return this.LookupCountryNump(ipa);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000571D4 File Offset: 0x000553D4
		public string LookupCountryCode(string IPA)
		{
			IPAddress ipa;
			try
			{
				ipa = IPAddress.Parse(IPA);
			}
			catch (FormatException ex)
			{
				return "--";
			}
			return this.LookupCountryCode(ipa);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00057220 File Offset: 0x00055420
		public string LookupCountryName(IPAddress addr)
		{
			return GeoIP.CountryName[checked((int)this.SeekCountry(0L, this.ConvertIPAddressToNumber(addr), 31))];
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0005724C File Offset: 0x0005544C
		public string LookupCountryName(string IPA)
		{
			IPAddress addr;
			try
			{
				addr = IPAddress.Parse(IPA);
			}
			catch (FormatException ex)
			{
				return "N/A";
			}
			return this.LookupCountryName(addr);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00057298 File Offset: 0x00055498
		private long vbShiftLeft(long Value, int Count)
		{
			long num = Value;
			checked
			{
				for (int i = 1; i <= Count; i++)
				{
					num *= 2L;
				}
				return num;
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000572BC File Offset: 0x000554BC
		private long vbShiftRight(long Value, int Count)
		{
			long num = Value;
			checked
			{
				for (int i = 1; i <= Count; i++)
				{
					num /= 2L;
				}
				return num;
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000572E0 File Offset: 0x000554E0
		private long SeekCountry(long StartOffset, long IPNumber, int SearchDepth)
		{
			byte[] array = new byte[7];
			long[] array2 = new long[3];
			bool flag = SearchDepth == 0;
			if (flag)
			{
			}
			checked
			{
				try
				{
					this.MS.Seek(6L * StartOffset, SeekOrigin.Begin);
					this.MS.Read(array, 0, 6);
				}
				catch (IOException ex)
				{
				}
				int num = 0;
				do
				{
					array2[num] = 0L;
					int num2 = 0;
					do
					{
						int num3 = (int)array[num * 3 + num2];
						bool flag2 = num3 < 0;
						if (flag2)
						{
							num3 += 256;
						}
						long[] array3 = array2;
						int num4 = num;
						ref long ptr = ref array3[num4];
						array3[num4] = ptr + this.vbShiftLeft(unchecked((long)num3), num2 * 8);
						num2++;
					}
					while (num2 <= 2);
					num++;
				}
				while (num <= 1);
				bool flag3 = (IPNumber & this.vbShiftLeft(1L, SearchDepth)) > 0L;
				long result;
				if (flag3)
				{
					bool flag4 = array2[1] >= GeoIP.CountryBegin;
					if (flag4)
					{
						result = array2[1] - GeoIP.CountryBegin;
					}
					else
					{
						result = this.SeekCountry(array2[1], IPNumber, SearchDepth - 1);
					}
				}
				else
				{
					bool flag5 = array2[0] >= GeoIP.CountryBegin;
					if (flag5)
					{
						result = array2[0] - GeoIP.CountryBegin;
					}
					else
					{
						result = this.SeekCountry(array2[0], IPNumber, SearchDepth - 1);
					}
				}
				return result;
			}
		}

		// Token: 0x04000417 RID: 1047
		public MemoryStream MS;

		// Token: 0x04000418 RID: 1048
		public static long CountryBegin = 16776960L;

		// Token: 0x04000419 RID: 1049
		public static string[] CountryName = new string[]
		{
			"LocalHost",
			"Asia/Pacific Region",
			"Europe",
			"Andorra",
			"United Arab Emirates",
			"Afghanistan",
			"Antigua and Barbuda",
			"Anguilla",
			"Albania",
			"Armenia",
			"Netherlands Antilles",
			"Angola",
			"Antarctica",
			"Argentina",
			"American Samoa",
			"Austria",
			"Australia",
			"Aruba",
			"Azerbaijan",
			"Bosnia and Herzegovina",
			"Barbados",
			"Bangladesh",
			"Belgium",
			"Burkina Faso",
			"Bulgaria",
			"Bahrain",
			"Burundi",
			"Benin",
			"Bermuda",
			"Brunei Darussalam",
			"Bolivia",
			"Brazil",
			"Bahamas",
			"Bhutan",
			"Bouvet Island",
			"Botswana",
			"Belarus",
			"Belize",
			"Canada",
			"Cocos (Keeling) Islands",
			"Congo, The Democratic Republic of the",
			"Central African Republic",
			"Congo",
			"Switzerland",
			"Cote D'Ivoire",
			"Cook Islands",
			"Chile",
			"Cameroon",
			"China",
			"Colombia",
			"Costa Rica",
			"Cuba",
			"Cape Verde",
			"Christmas Island",
			"Cyprus",
			"Czech Republic",
			"Germany",
			"Djibouti",
			"Denmark",
			"Dominica",
			"Dominican Republic",
			"Algeria",
			"Ecuador",
			"Estonia",
			"Egypt",
			"Western Sahara",
			"Eritrea",
			"Spain",
			"Ethiopia",
			"Finland",
			"Fiji",
			"Falkland Islands (Malvinas)",
			"Micronesia, Federated States of",
			"Faroe Islands",
			"France",
			"France, Metropolitan",
			"Gabon",
			"United Kingdom",
			"Grenada",
			"Georgia",
			"French Guiana",
			"Ghana",
			"Gibraltar",
			"Greenland",
			"Gambia",
			"Guinea",
			"Guadeloupe",
			"Equatorial Guinea",
			"Greece",
			"South Georgia and the South Sandwich Islands",
			"Guatemala",
			"Guam",
			"Guinea-Bissau",
			"Guyana",
			"Hong Kong",
			"Heard Island and McDonald Islands",
			"Honduras",
			"Croatia",
			"Haiti",
			"Hungary",
			"Indonesia",
			"Ireland",
			"Israel",
			"India",
			"British Indian Ocean Territory",
			"Iraq",
			"Iran, Islamic Republic of",
			"Iceland",
			"Italy",
			"Jamaica",
			"Jordan",
			"Japan",
			"Kenya",
			"Kyrgyzstan",
			"Cambodia",
			"Kiribati",
			"Comoros",
			"Saint Kitts and Nevis",
			"Korea, Democratic People's Republic of",
			"Korea, Republic of",
			"Kuwait",
			"Cayman Islands",
			"Kazakstan",
			"Lao People's Democratic Republic",
			"Lebanon",
			"Saint Lucia",
			"Liechtenstein",
			"Sri Lanka",
			"Liberia",
			"Lesotho",
			"Lithuania",
			"Luxembourg",
			"Latvia",
			"Libyan Arab Jamahiriya",
			"Morocco",
			"Monaco",
			"Moldova, Republic of",
			"Madagascar",
			"Marshall Islands",
			"Macedonia, the Former Yugoslav Republic of",
			"Mali",
			"Myanmar",
			"Mongolia",
			"Macao",
			"Northern Mariana Islands",
			"Martinique",
			"Mauritania",
			"Montserrat",
			"Malta",
			"Mauritius",
			"Maldives",
			"Malawi",
			"Mexico",
			"Malaysia",
			"Mozambique",
			"Namibia",
			"New Caledonia",
			"Niger",
			"Norfolk Island",
			"Nigeria",
			"Nicaragua",
			"Netherlands",
			"Norway",
			"Nepal",
			"Nauru",
			"Niue",
			"New Zealand",
			"Oman",
			"Panama",
			"Peru",
			"French Polynesia",
			"Papua New Guinea",
			"Philippines",
			"Pakistan",
			"Poland",
			"Saint Pierre and Miquelon",
			"Pitcairn",
			"Puerto Rico",
			"Palestinian Territory, Occupied",
			"Portugal",
			"Palau",
			"Paraguay",
			"Qatar",
			"Reunion",
			"Romania",
			"Russian Federation",
			"Rwanda",
			"Saudi Arabia",
			"Solomon Islands",
			"Seychelles",
			"Sudan",
			"Sweden",
			"Singapore",
			"Saint Helena",
			"Slovenia",
			"Svalbard and Jan Mayen",
			"Slovakia",
			"Sierra Leone",
			"San Marino",
			"Senegal",
			"Somalia",
			"Suriname",
			"Sao Tome and Principe",
			"El Salvador",
			"Syrian Arab Republic",
			"Swaziland",
			"Turks and Caicos Islands",
			"Chad",
			"French Southern Territories",
			"Togo",
			"Thailand",
			"Tajikistan",
			"Tokelau",
			"Turkmenistan",
			"Tunisia",
			"Tonga",
			"Timor-Leste",
			"Turkey",
			"Trinidad and Tobago",
			"Tuvalu",
			"Taiwan, Province of China",
			"Tanzania, United Republic of",
			"Ukraine",
			"Uganda",
			"United States Minor Outlying Islands",
			"United States",
			"Uruguay",
			"Uzbekistan",
			"Holy See (Vatican City State)",
			"Saint Vincent and the Grenadines",
			"Venezuela",
			"Virgin Islands, British",
			"Virgin Islands, U.S.",
			"Vietnam",
			"Vanuatu",
			"Wallis and Futuna",
			"Samoa",
			"Yemen",
			"Mayotte",
			"Yugoslavia",
			"South Africa",
			"Zambia",
			"Montenegro",
			"Zimbabwe",
			"Anonymous Proxy",
			"Satellite Provider",
			"Other",
			"Aland Islands",
			"Guernsey",
			"Isle of Man",
			"Jersey",
			"Saint Barthelemy",
			"Saint Martin"
		};

		// Token: 0x0400041A RID: 1050
		public static string[] CountryCode = new string[]
		{
			"--",
			"AP",
			"EU",
			"AD",
			"AE",
			"AF",
			"AG",
			"AI",
			"AL",
			"AM",
			"AN",
			"AO",
			"AQ",
			"AR",
			"AS",
			"AT",
			"AU",
			"AW",
			"AZ",
			"BA",
			"BB",
			"BD",
			"BE",
			"BF",
			"BG",
			"BH",
			"BI",
			"BJ",
			"BM",
			"BN",
			"BO",
			"BR",
			"BS",
			"BT",
			"BV",
			"BW",
			"BY",
			"BZ",
			"CA",
			"CC",
			"CD",
			"CF",
			"CG",
			"CH",
			"CI",
			"CK",
			"CL",
			"CM",
			"CN",
			"CO",
			"CR",
			"CU",
			"CV",
			"CX",
			"CY",
			"CZ",
			"DE",
			"DJ",
			"DK",
			"DM",
			"DO",
			"DZ",
			"EC",
			"EE",
			"EG",
			"EH",
			"ER",
			"ES",
			"ET",
			"FI",
			"FJ",
			"FK",
			"FM",
			"FO",
			"FR",
			"FX",
			"GA",
			"GB",
			"GD",
			"GE",
			"GF",
			"GH",
			"GI",
			"GL",
			"GM",
			"GN",
			"GP",
			"GQ",
			"GR",
			"GS",
			"GT",
			"GU",
			"GW",
			"GY",
			"HK",
			"HM",
			"HN",
			"HR",
			"HT",
			"HU",
			"ID",
			"IE",
			"IL",
			"IN",
			"IO",
			"IQ",
			"IR",
			"IS",
			"IT",
			"JM",
			"JO",
			"JP",
			"KE",
			"KG",
			"KH",
			"KI",
			"KM",
			"KN",
			"KP",
			"KR",
			"KW",
			"KY",
			"KZ",
			"LA",
			"LB",
			"LC",
			"LI",
			"LK",
			"LR",
			"LS",
			"LT",
			"LU",
			"LV",
			"LY",
			"MA",
			"MC",
			"MD",
			"MG",
			"MH",
			"MK",
			"ML",
			"MM",
			"MN",
			"MO",
			"MP",
			"MQ",
			"MR",
			"MS",
			"MT",
			"MU",
			"MV",
			"MW",
			"MX",
			"MY",
			"MZ",
			"NA",
			"NC",
			"NE",
			"NF",
			"NG",
			"NI",
			"NL",
			"NO",
			"NP",
			"NR",
			"NU",
			"NZ",
			"OM",
			"PA",
			"PE",
			"PF",
			"PG",
			"PH",
			"PK",
			"PL",
			"PM",
			"PN",
			"PR",
			"PS",
			"PT",
			"PW",
			"PY",
			"QA",
			"RE",
			"RO",
			"RU",
			"RW",
			"SA",
			"SB",
			"SC",
			"SD",
			"SE",
			"SG",
			"SH",
			"SI",
			"SJ",
			"SK",
			"SL",
			"SM",
			"SN",
			"SO",
			"SR",
			"ST",
			"SV",
			"SY",
			"SZ",
			"TC",
			"TD",
			"TF",
			"TG",
			"TH",
			"TJ",
			"TK",
			"TM",
			"TN",
			"TO",
			"TL",
			"TR",
			"TT",
			"TV",
			"TW",
			"TZ",
			"UA",
			"UG",
			"UM",
			"US",
			"UY",
			"UZ",
			"VA",
			"VC",
			"VE",
			"VG",
			"VI",
			"VN",
			"VU",
			"WF",
			"WS",
			"YE",
			"YT",
			"SAU",
			"RS",
			"ZA",
			"ZM",
			"ME",
			"ZW",
			"A1",
			"A2",
			"O1",
			"AX",
			"GG",
			"IM",
			"JE",
			"BL",
			"MF"
		};

		// Token: 0x0400041B RID: 1051
		public static string[] CountryNump = new string[]
		{
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"11",
			"12",
			"13",
			"14",
			"15",
			"16",
			"17",
			"18",
			"19",
			"20",
			"21",
			"22",
			"23",
			"24",
			"25",
			"26",
			"27",
			"28",
			"29",
			"30",
			"31",
			"32",
			"33",
			"34",
			"35",
			"36",
			"37",
			"38",
			"39",
			"40",
			"41",
			"42",
			"43",
			"44",
			"45",
			"46",
			"47",
			"48",
			"49",
			"50",
			"51",
			"52",
			"53",
			"54",
			"55",
			"56",
			"57",
			"58",
			"59",
			"60",
			"61",
			"62",
			"63",
			"64",
			"65",
			"66",
			"67",
			"68",
			"69",
			"70",
			"71",
			"72",
			"73",
			"74",
			"75",
			"76",
			"77",
			"78",
			"79",
			"80",
			"81",
			"82",
			"83",
			"84",
			"85",
			"86",
			"87",
			"88",
			"89",
			"90",
			"91",
			"92",
			"93",
			"94",
			"95",
			"96",
			"97",
			"98",
			"99",
			"100",
			"101",
			"102",
			"103",
			"104",
			"105",
			"106",
			"107",
			"108",
			"109",
			"110",
			"111",
			"112",
			"113",
			"114",
			"115",
			"116",
			"117",
			"118",
			"119",
			"120",
			"121",
			"122",
			"123",
			"124",
			"125",
			"126",
			"127",
			"128",
			"129",
			"130",
			"131",
			"132",
			"133",
			"134",
			"135",
			"136",
			"137",
			"138",
			"139",
			"140",
			"141",
			"142",
			"143",
			"144",
			"145",
			"146",
			"147",
			"148",
			"149",
			"150",
			"151",
			"152",
			"153",
			"154",
			"155",
			"156",
			"157",
			"158",
			"159",
			"160",
			"161",
			"162",
			"163",
			"164",
			"165",
			"166",
			"167",
			"168",
			"169",
			"170",
			"171",
			"172",
			"173",
			"174",
			"175",
			"176",
			"177",
			"178",
			"179",
			"180",
			"181",
			"182",
			"183",
			"184",
			"185",
			"186",
			"187",
			"188",
			"189",
			"190",
			"191",
			"192",
			"193",
			"194",
			"195",
			"196",
			"197",
			"198",
			"199",
			"200",
			"201",
			"202",
			"203",
			"204",
			"205",
			"206",
			"207",
			"208",
			"209",
			"210",
			"211",
			"212",
			"213",
			"214",
			"215",
			"216",
			"217",
			"218",
			"219",
			"220",
			"221",
			"222",
			"223",
			"224",
			"225",
			"226",
			"227",
			"228",
			"229",
			"230",
			"231",
			"232",
			"233",
			"234",
			"235",
			"236",
			"237",
			"238",
			"239",
			"240",
			"241",
			"242",
			"243",
			"244",
			"245",
			"246",
			"247",
			"248",
			"249",
			"250",
			"251",
			"252",
			"253",
			"254"
		};
	}
}

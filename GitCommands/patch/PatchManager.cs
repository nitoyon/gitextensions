using System.Text.RegularExpressions;
                    Match match = Regex.Match(input, "[ ][\"]{0,1}[a]/(.*)[\"]{0,1}[ ][\"]{0,1}[b]/(.*)[\"]{0,1}");

                    patch.FileNameA = match.Groups[1].Value;
                    patch.FileNameB = match.Groups[2].Value;
                    //patch.FileNameA = input.Substring(input.LastIndexOf(" a/") + 3, input.LastIndexOf(" b/") - (input.LastIndexOf(" a/") + 3));
                    //patch.FileNameB = input.Substring(input.LastIndexOf(" b/") + 3);
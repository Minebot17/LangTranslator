using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Linq;
using Newtonsoft.Json;

namespace LangTranslator {
	public partial class MainForm : Form {
		YandexTranslator translator = new YandexTranslator();
		Dictionary<string, string> dic = new Dictionary<string, string>();
        Dictionary<string, string> userDic = new Dictionary<string, string>();
		bool small;

		public MainForm() {
			InitializeComponent();
			dic.Add("ru_RU", "ru");
			dic.Add("en_US", "en");
			dic.Add("ar_SA", "ar");
			dic.Add("az_AZ", "az");
			dic.Add("de_DE", "de");
			dic.Add("eo_UY", "eo");
			dic.Add("es_ES", "es");
			dic.Add("fr_FR", "fr");
			dic.Add("ga_IE", "ga");
			dic.Add("gd_GB", "gd");
			dic.Add("hy_AM", "hy");
			dic.Add("it_IT", "it");
			dic.Add("ja_JP", "ja");
			dic.Add("pl_PL", "pl");
			dic.Add("pt_PT", "pt");
			dic.Add("uk_UA", "uk");
			dic.Add("zh_CN", "zh");

			List<string> keys = new List<string>(dic.Keys);
			for (int i = 0; i < dic.Count; i++)
				to.Items.Add(keys[i]);
		}

		private void open_Click(object sender, EventArgs e) {
			DialogResult result = openFile.ShowDialog();
			if (result != DialogResult.Cancel) {
				translateButton.Enabled = true;
                fileNameLabel.Text = openFile.SafeFileName.Length <= 15 ? openFile.SafeFileName : openFile.SafeFileName.Substring(0, 15) + "...";
            }
		}

        private void customListLoadButton_Click(object sender, EventArgs e) {
            DialogResult result = openList.ShowDialog();
            if (result != DialogResult.Cancel) {
                string[] file = File.ReadAllLines(openList.FileName);
                for (int i = 0; i < file.Length; i++) {
                    string[] splited = file[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    userDic.Add(splited[0], splited.Length == 1 ? "empty" : splited[1]);
                }
                listNameLabel.Text = openList.SafeFileName.Length <= 15 ? openList.SafeFileName : openList.SafeFileName.Substring(0, 15) + "...";
            }
        }

        private void smallRegister_CheckedChanged(object sender, EventArgs e) {
			small = smallRegister.Checked;
		}

		private void translateButton_Click(object sender, EventArgs e) {
			if (dic.ContainsKey(to.Text)) {
				if (File.Exists(openFile.FileName)) {
					string[] file = File.ReadAllLines(openFile.FileName);
					string[] result = new string[file.Length];
					for (int i = 0; i < file.Length; i++) {
						if (file[i].Contains("=")) {
							string[] splited = file[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                            if (splited.Length == 1) {
                                result[i] = splited[0] + "=";
                                continue;
                            }

                            string resultText = "";
                            string[] secondSplited = SplitAndKeep(splited[1], userDic.Keys.ToArray()).ToArray();
                            for (int j = 0; j < secondSplited.Length; j++) {
                                string toAdd = secondSplited[j];
                                string value = null;
                                try { value = userDic[toAdd]; } catch (Exception d) { }
                                resultText += value == null ? translator.Translate(toAdd, dic[to.Text]) : value.Equals("empty") ? toAdd : value;
                            }
                            result[i] = splited[0] + "=" + resultText;
						}
					}
					File.WriteAllLines(openFile.FileName.Substring(0, openFile.FileName.Length - openFile.SafeFileName.Length) + (small ? to.Text.ToLower() : to.Text) + ".lang", result);
					MessageBox.Show("Успешно переведенно!");
				}
				else
					MessageBox.Show("Указанного lang файла не существует", "Ошибка");
			}
			else
				MessageBox.Show("Введите язык правильно", "Ошибка");
		}

		private void yandex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("https://translate.yandex.ru/");
		}

        static IEnumerable<string> SplitAndKeep(string s, params string[] delims) {
            var rows = new List<string>() { s };
            foreach (string delim in delims)//delimiter counter
            {
                for (int i = 0; i < rows.Count; i++)//row counter
                {
                    int index = rows[i].IndexOf(delim);
                    if (index > -1
                        && rows[i].Length > index + 1 && !rows[i].Equals(delim)) {
                        string leftPart = rows[i].Substring(0, index);
                        string centerPart = rows[i].Substring(index, delim.Length);
                        string rightPart = rows[i].Substring(index + delim.Length);
                        rows[i] = leftPart;
                        rows.Insert(i + 1, centerPart);
                        rows.Insert(i + 2, rightPart);
                    }
                }
            }
            return rows;
        }
    }

    class YandexTranslator {
		public string Translate(string s, string lang) {
			if (s.Length > 0) {
				WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
					+ "key=trnsl.1.1.20170731T101955Z.360d16f26201aaf1.74a0721586017a1c6144f87a54a9092d9e9765d3"
					+ "&text=" + s
					+ "&lang=" + lang);

				WebResponse response = request.GetResponse();

				using (StreamReader stream = new StreamReader(response.GetResponseStream())) {
					string line;

					if ((line = stream.ReadLine()) != null) {
						Translation translation = JsonConvert.DeserializeObject<Translation>(line);

						s = "";

						foreach (string str in translation.text) {
							s += str;
						}
					}
				}

				return s;
			}
			else
				return "";
		}
	}

	class Translation {
		public string code { get; set; }
		public string lang { get; set; }
		public string[] text { get; set; }
	}
}

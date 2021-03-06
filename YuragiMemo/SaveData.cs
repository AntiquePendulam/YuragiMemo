﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YuragiMemo
{
    [JsonObject]
    public class SaveData
    {
        //座標
        [JsonProperty("left")]
        public double Left { get; set; } = 50.0;
        [JsonProperty("top")]
        public double Top { get; set; } = 20.0;

        [JsonProperty("width")]
        public double Width { get; set; } = 300.0;

        [JsonProperty("Height")]
        public double Height { get; set; } = 300.0;

        [JsonProperty("color")]
        public ColorData WorldColor { get; set; } = new ColorData();

        //メモテキスト
        [JsonProperty("text")]
        public string Text { get; set; } = "";
    }
}

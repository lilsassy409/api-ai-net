﻿//
// API.AI .NET SDK - client-side libraries for API.AI
// =================================================
//
// Copyright (C) 2015 by Speaktoit, Inc. (https://www.speaktoit.com)
// https://www.api.ai
//
// ***********************************************************************************************************************
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//
// ***********************************************************************************************************************

using System;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiAiSDK.Model
{
    [JsonObject]
	public class QuestionMetadata
	{
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		[JsonProperty("lang")]
		public string Language { get; set; }

		[JsonProperty("sessionId")]
		public string SessionId { get; set; }

        [JsonProperty("entities")]
        public List<Entity> Entities { get; set; }
	}
}

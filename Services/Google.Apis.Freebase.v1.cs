//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4971
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Freebase.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class ContentserviceGet : Google.Apis.Requests.IDirectResponseSchema {
        
        private string _result;
        
        private string _ETag;
        
        /// <summary>The text requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result {
            get {
                return this._result;
            }
            set {
                this._result = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
}
namespace Google.Apis.Freebase.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class FreebaseService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService _service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"discoveryVersion\":\"v1\",\"id\":\"freebase:v1\",\"n" +
            "ame\":\"freebase\",\"version\":\"v1\",\"revision\":\"20120421\",\"title\":\"Freebase API\",\"des" +
            "cription\":\"Lets you access the Freebase repository of open data.\",\"icons\":{\"x16\"" +
            ":\"http://www.google.com/images/icons/product/freebase-16.png\",\"x32\":\"http://www." +
            "google.com/images/icons/product/freebase-32.png\"},\"documentationLink\":\"http://wi" +
            "ki.freebase.com/wiki/API\",\"protocol\":\"rest\",\"baseUrl\":\"https://www.googleapis.co" +
            "m/freebase/v1/\",\"basePath\":\"/freebase/v1/\",\"rootUrl\":\"https://www.googleapis.com" +
            "/\",\"servicePath\":\"freebase/v1/\",\"batchPath\":\"batch\",\"parameters\":{\"alt\":{\"type\":" +
            "\"string\",\"description\":\"Data format for the response.\",\"default\":\"json\",\"enum\":[" +
            "\"json\"],\"enumDescriptions\":[\"Responses with Content-Type of application/json\"],\"" +
            "location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Selector specifying " +
            "which fields to include in a partial response.\",\"location\":\"query\"},\"key\":{\"type" +
            "\":\"string\",\"description\":\"API key. Your API key identifies your project and prov" +
            "ides you with API access, quota, and reports. Required unless you provide an OAu" +
            "th 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"description\":" +
            "\"OAuth 2.0 token for the current user.\",\"location\":\"query\"},\"prettyPrint\":{\"type" +
            "\":\"boolean\",\"description\":\"Returns response with indentations and line breaks.\"," +
            "\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"string\",\"description\":" +
            "\"Available to use for quota purposes for server-side applications. Can be any ar" +
            "bitrary string assigned to a user, but should not exceed 40 characters. Override" +
            "s userIp if both are provided.\",\"location\":\"query\"},\"userIp\":{\"type\":\"string\",\"d" +
            "escription\":\"IP address of the site where the request originates. Use this if yo" +
            "u want to enforce per-user limits.\",\"location\":\"query\"}},\"schemas\":{\"Contentserv" +
            "iceGet\":{\"id\":\"ContentserviceGet\",\"type\":\"object\",\"properties\":{\"result\":{\"type\"" +
            ":\"string\",\"description\":\"The text requested.\"}}}},\"methods\":{\"image\":{\"id\":\"free" +
            "base.image\",\"path\":\"image{/id*}\",\"httpMethod\":\"GET\",\"description\":\"Returns the s" +
            "caled/cropped image attached to a freebase node.\",\"parameters\":{\"fallbackid\":{\"t" +
            "ype\":\"string\",\"description\":\"Use the image associated with this secondary id if " +
            "no image is associated with the primary id.\",\"default\":\"/freebase/no_image_png\"," +
            "\"pattern\":\"/[^.]*$\",\"location\":\"query\"},\"id\":{\"type\":\"string\",\"description\":\"Fre" +
            "ebase entity or content id, mid, or guid.\",\"required\":true,\"repeated\":true,\"loca" +
            "tion\":\"path\"},\"maxheight\":{\"type\":\"integer\",\"description\":\"Maximum height in pix" +
            "els for resulting image.\",\"format\":\"uint32\",\"maximum\":\"4096\",\"location\":\"query\"}" +
            ",\"maxwidth\":{\"type\":\"integer\",\"description\":\"Maximum width in pixels for resulti" +
            "ng image.\",\"format\":\"uint32\",\"maximum\":\"4096\",\"location\":\"query\"},\"mode\":{\"type\"" +
            ":\"string\",\"description\":\"Method used to scale or crop image.\",\"default\":\"fit\",\"e" +
            "num\":[\"fill\",\"fillcrop\",\"fillcropmid\",\"fit\"],\"enumDescriptions\":[\"Fill rectangle" +
            " completely with image, relax constraint on one dimension if necessary.\",\"Fill r" +
            "ectangle with image, crop image to maintain rectangle dimensions.\",\"Fill rectang" +
            "le with image, center horizontally, crop left and right.\",\"Fit image inside rect" +
            "angle, leave empty space in one dimension if necessary.\"],\"location\":\"query\"},\"p" +
            "ad\":{\"type\":\"boolean\",\"description\":\"A boolean specifying whether the resulting " +
            "image should be padded up to the requested dimensions.\",\"default\":\"false\",\"locat" +
            "ion\":\"query\"}},\"parameterOrder\":[\"id\"],\"supportsMediaDownload\":true},\"mqlread\":{" +
            "\"id\":\"freebase.mqlread\",\"path\":\"mqlread\",\"httpMethod\":\"GET\",\"description\":\"Perfo" +
            "rms MQL Queries.\",\"parameters\":{\"as_of_time\":{\"type\":\"string\",\"description\":\"Run" +
            " the query as it would\'ve been run at the specified point in time.\",\"location\":\"" +
            "query\"},\"callback\":{\"type\":\"string\",\"description\":\"JS method name for JSONP call" +
            "backs.\",\"pattern\":\"([A-Za-z0-9_$.]|\\\\[|\\\\])+\",\"location\":\"query\"},\"cost\":{\"type\"" +
            ":\"boolean\",\"description\":\"Show the costs or not.\",\"default\":\"false\",\"location\":\"" +
            "query\"},\"cursor\":{\"type\":\"string\",\"description\":\"The mql cursor.\",\"location\":\"qu" +
            "ery\"},\"dateline\":{\"type\":\"string\",\"description\":\"The dateline that you get in a " +
            "mqlwrite response to ensure consistent results.\",\"location\":\"query\"},\"html_escap" +
            "e\":{\"type\":\"boolean\",\"description\":\"Whether or not to escape entities.\",\"default" +
            "\":\"true\",\"location\":\"query\"},\"indent\":{\"type\":\"integer\",\"description\":\"How many " +
            "spaces to indent the json.\",\"default\":\"0\",\"format\":\"uint32\",\"maximum\":\"10\",\"loca" +
            "tion\":\"query\"},\"lang\":{\"type\":\"string\",\"description\":\"The language of the result" +
            "s - an id of a /type/lang object.\",\"default\":\"/lang/en\",\"location\":\"query\"},\"que" +
            "ry\":{\"type\":\"string\",\"description\":\"An envelope containing a single MQL query.\"," +
            "\"required\":true,\"location\":\"query\"},\"uniqueness_failure\":{\"type\":\"string\",\"descr" +
            "iption\":\"How MQL responds to uniqueness failures.\",\"default\":\"hard\",\"enum\":[\"har" +
            "d\",\"soft\"],\"enumDescriptions\":[\"Be strict - throw an error.\",\"Just return the fi" +
            "rst encountered object.\"],\"location\":\"query\"}},\"parameterOrder\":[\"query\"],\"suppo" +
            "rtsMediaDownload\":true}},\"resources\":{\"text\":{\"methods\":{\"get\":{\"id\":\"freebase.t" +
            "ext.get\",\"path\":\"text{/id*}\",\"httpMethod\":\"GET\",\"description\":\"Returns blob atta" +
            "ched to node at specified id as HTML\",\"parameters\":{\"format\":{\"type\":\"string\",\"d" +
            "escription\":\"Sanitizing transformation.\",\"default\":\"plain\",\"enum\":[\"html\",\"plain" +
            "\",\"raw\"],\"enumDescriptions\":[\"Return valid, sanitized html.\",\"Return plain text " +
            "- strip html tags.\",\"Return the entire content as-is.\"],\"location\":\"query\"},\"id\"" +
            ":{\"type\":\"string\",\"description\":\"The id of the item that you want data about\",\"r" +
            "equired\":true,\"repeated\":true,\"location\":\"path\"},\"maxlength\":{\"type\":\"integer\",\"" +
            "description\":\"The max number of characters to return. Valid only for \'plain\' for" +
            "mat.\",\"format\":\"uint32\",\"location\":\"query\"}},\"parameterOrder\":[\"id\"],\"response\":" +
            "{\"$ref\":\"ContentserviceGet\"}}}}}}";
        
        public const string Version = "v1";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected FreebaseService(Google.Apis.Discovery.IService _service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this._service = _service;
            this._authenticator = _authenticator;
            this._text = new TextResource(this, _authenticator);
        }
        
        public FreebaseService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public FreebaseService(Google.Apis.Authentication.IAuthenticator _authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(FreebaseService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri("https://www.googleapis.com/freebase/v1/"))), _authenticator) {
        }
        
        public Google.Apis.Authentication.IAuthenticator Authenticator {
            get {
                return this._authenticator;
            }
        }
        
        public virtual string Name {
            get {
                return "freebase";
            }
        }
        
        public virtual string BaseUri {
            get {
                return "https://www.googleapis.com/freebase/v1/";
            }
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this._service.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(_authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            _service.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return _service.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return _service.DeserializeResponse<T>(response);
        }
    }
    
    public class TextResource {
        
        private FreebaseService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "text";
        
        public TextResource(FreebaseService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>Returns blob attached to node at specified id as HTML</summary>
        /// <param name="id">Required - The id of the item that you want data about</param>
        public virtual GetRequest Get(Google.Apis.Util.Repeatable<string> id) {
            return new GetRequest(service, id);
        }
        
        /// <summary>Sanitizing transformation.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Format {
            
            /// <summary>Return valid, sanitized html.</summary>
            [Google.Apis.Util.StringValueAttribute("html")]
            Html,
            
            /// <summary>Return plain text - strip html tags.</summary>
            [Google.Apis.Util.StringValueAttribute("plain")]
            Plain,
            
            /// <summary>Return the entire content as-is.</summary>
            [Google.Apis.Util.StringValueAttribute("raw")]
            Raw,
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Freebase.v1.Data.ContentserviceGet> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private System.Nullable<Format> _format;
            
            private Google.Apis.Util.Repeatable<string> _id;
            
            private System.Nullable<long> _maxlength;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> id) : 
                    base(service) {
                this._id = id;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>Sanitizing transformation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Format> Format {
                get {
                    return this._format;
                }
                set {
                    this._format = value;
                }
            }
            
            /// <summary>The id of the item that you want data about</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual Google.Apis.Util.Repeatable<string> Id {
                get {
                    return this._id;
                }
            }
            
            /// <summary>The max number of characters to return. Valid only for 'plain' format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxlength", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Maxlength {
                get {
                    return this._maxlength;
                }
                set {
                    this._maxlength = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "text";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
    }
    
    public partial class FreebaseService {
        
        private const string Resource = "";
        
        private TextResource _text;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual TextResource Text {
            get {
                return this._text;
            }
        }
        
        /// <summary>Returns the scaled/cropped image attached to a freebase node.</summary>
        /// <param name="id">Required - Freebase entity or content id, mid, or guid.</param>
        public virtual ImageRequest Image(Google.Apis.Util.Repeatable<string> id) {
            return new ImageRequest(service, id);
        }
        
        /// <summary>Performs MQL Queries.</summary>
        /// <param name="query">Required - An envelope containing a single MQL query.</param>
        public virtual MqlreadRequest Mqlread(string query) {
            return new MqlreadRequest(service, query);
        }
        
        /// <summary>Method used to scale or crop image.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Mode {
            
            /// <summary>Fill rectangle completely with image, relax constraint on one dimension if necessary.</summary>
            [Google.Apis.Util.StringValueAttribute("fill")]
            Fill,
            
            /// <summary>Fill rectangle with image, crop image to maintain rectangle dimensions.</summary>
            [Google.Apis.Util.StringValueAttribute("fillcrop")]
            Fillcrop,
            
            /// <summary>Fill rectangle with image, center horizontally, crop left and right.</summary>
            [Google.Apis.Util.StringValueAttribute("fillcropmid")]
            Fillcropmid,
            
            /// <summary>Fit image inside rectangle, leave empty space in one dimension if necessary.</summary>
            [Google.Apis.Util.StringValueAttribute("fit")]
            Fit,
        }
        
        /// <summary>How MQL responds to uniqueness failures.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Uniqueness_failure {
            
            /// <summary>Be strict - throw an error.</summary>
            [Google.Apis.Util.StringValueAttribute("hard")]
            Hard,
            
            /// <summary>Just return the first encountered object.</summary>
            [Google.Apis.Util.StringValueAttribute("soft")]
            Soft,
        }
        
        public class ImageRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _fallbackid;
            
            private Google.Apis.Util.Repeatable<string> _id;
            
            private System.Nullable<long> _maxheight;
            
            private System.Nullable<long> _maxwidth;
            
            private System.Nullable<Mode> _mode;
            
            private System.Nullable<bool> _pad;
            
            public ImageRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> id) : 
                    base(service) {
                this._id = id;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>Use the image associated with this secondary id if no image is associated with the primary id.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fallbackid", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fallbackid {
                get {
                    return this._fallbackid;
                }
                set {
                    this._fallbackid = value;
                }
            }
            
            /// <summary>Freebase entity or content id, mid, or guid.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual Google.Apis.Util.Repeatable<string> Id {
                get {
                    return this._id;
                }
            }
            
            /// <summary>Maximum height in pixels for resulting image.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxheight", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Maxheight {
                get {
                    return this._maxheight;
                }
                set {
                    this._maxheight = value;
                }
            }
            
            /// <summary>Maximum width in pixels for resulting image.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxwidth", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Maxwidth {
                get {
                    return this._maxwidth;
                }
                set {
                    this._maxwidth = value;
                }
            }
            
            /// <summary>Method used to scale or crop image.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Mode> Mode {
                get {
                    return this._mode;
                }
                set {
                    this._mode = value;
                }
            }
            
            /// <summary>A boolean specifying whether the resulting image should be padded up to the requested dimensions.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pad", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Pad {
                get {
                    return this._pad;
                }
                set {
                    this._pad = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "";
                }
            }
            
            protected override string MethodName {
                get {
                    return "image";
                }
            }
        }
        
        public class MqlreadRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _as_of_time;
            
            private string _callback;
            
            private System.Nullable<bool> _cost;
            
            private string _cursor;
            
            private string _dateline;
            
            private System.Nullable<bool> _html_escape;
            
            private System.Nullable<long> _indent;
            
            private string _lang;
            
            private string _query;
            
            private System.Nullable<Uniqueness_failure> _uniqueness_failure;
            
            public MqlreadRequest(Google.Apis.Discovery.IRequestProvider service, string query) : 
                    base(service) {
                this._query = query;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>Run the query as it would've been run at the specified point in time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("as_of_time", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string As_of_time {
                get {
                    return this._as_of_time;
                }
                set {
                    this._as_of_time = value;
                }
            }
            
            /// <summary>JS method name for JSONP callbacks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Callback {
                get {
                    return this._callback;
                }
                set {
                    this._callback = value;
                }
            }
            
            /// <summary>Show the costs or not.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cost", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Cost {
                get {
                    return this._cost;
                }
                set {
                    this._cost = value;
                }
            }
            
            /// <summary>The mql cursor.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cursor", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Cursor {
                get {
                    return this._cursor;
                }
                set {
                    this._cursor = value;
                }
            }
            
            /// <summary>The dateline that you get in a mqlwrite response to ensure consistent results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dateline", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Dateline {
                get {
                    return this._dateline;
                }
                set {
                    this._dateline = value;
                }
            }
            
            /// <summary>Whether or not to escape entities.</summary>
            [Google.Apis.Util.RequestParameterAttribute("html_escape", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Html_escape {
                get {
                    return this._html_escape;
                }
                set {
                    this._html_escape = value;
                }
            }
            
            /// <summary>How many spaces to indent the json.</summary>
            [Google.Apis.Util.RequestParameterAttribute("indent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Indent {
                get {
                    return this._indent;
                }
                set {
                    this._indent = value;
                }
            }
            
            /// <summary>The language of the results - an id of a /type/lang object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("lang", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Lang {
                get {
                    return this._lang;
                }
                set {
                    this._lang = value;
                }
            }
            
            /// <summary>An envelope containing a single MQL query.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query {
                get {
                    return this._query;
                }
            }
            
            /// <summary>How MQL responds to uniqueness failures.</summary>
            [Google.Apis.Util.RequestParameterAttribute("uniqueness_failure", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Uniqueness_failure> Uniqueness_failure {
                get {
                    return this._uniqueness_failure;
                }
                set {
                    this._uniqueness_failure = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "";
                }
            }
            
            protected override string MethodName {
                get {
                    return "mqlread";
                }
            }
        }
    }
}

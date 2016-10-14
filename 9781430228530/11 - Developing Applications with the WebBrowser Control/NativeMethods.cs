using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WebBrowserSample
{

    public sealed class INET
    {
        public const int E_INVALID_URL = unchecked((int)0x800C0002);
        public const int E_NO_SESSION = unchecked((int)0x800C0003);
        public const int E_CANNOT_CONNECT = unchecked((int)0x800C0004);
        public const int E_RESOURCE_NOT_FOUND = unchecked((int)0x800C0005);
        public const int E_OBJECT_NOT_FOUND = unchecked((int)0x800C0006);
        public const int E_DATA_NOT_AVAILABLE = unchecked((int)0x800C0007);
        public const int E_DOWNLOAD_FAILURE = unchecked((int)0x800C0008);
        public const int E_AUTHENTICATION_REQUIRED = unchecked((int)0x800C0009);
        public const int E_NO_VALID_MEDIA = unchecked((int)0x800C000A);
        public const int E_CONNECTION_TIMEOUT = unchecked((int)0x800C000B);
        public const int E_INVALID_REQUEST = unchecked((int)0x800C000C);
        public const int E_UNKNOWN_PROTOCOL = unchecked((int)0x800C000D);
        public const int E_SECURITY_PROBLEM = unchecked((int)0x800C000E);
        public const int E_CANNOT_LOAD_DATA = unchecked((int)0x800C000F);
        public const int E_CANNOT_INSTANTIATE_OBJECT = unchecked((int)0x800C0010);
        public const int E_USE_DEFAULT_PROTOCOLHANDLER = unchecked((int)0x800C0011);
        public const int E_USE_DEFAULT_SETTING = unchecked((int)0x800C0012);
        public const int E_DEFAULT_ACTION = unchecked((int)0x800C0011);
        public const int E_QUERYOPTION_UNKNOWN = unchecked((int)0x800C0013);
        public const int E_REDIRECTING = unchecked((int)0x800C0014);
        public const int E_REDIRECT_FAILED = unchecked((int)0x800C0014);
        public const int E_REDIRECT_TO_DIR = unchecked((int)0x800C0015);
        public const int E_CANNOT_LOCK_REQUEST = unchecked((int)0x800C0016);
        public const int E_ERROR_FIRST = unchecked((int)0x800C0002);
        public const int E_ERROR_LAST = E_REDIRECT_TO_DIR;
    }

    public static class Constants
    {
        public const int S_OK = unchecked(0x00000000);
        public const int E_NOINTERFACE = unchecked((int)0x80004002);
    }

    public static class IIDs
    {

        public static Guid IID_IProfferService = new Guid("cb728b20-f786-11ce-92ad-00aa00a74cd0");
        public static Guid SID_SProfferService = new Guid("cb728b20-f786-11ce-92ad-00aa00a74cd0");
        public static Guid IID_IInternetSecurityManager = new Guid("79eac9ee-baf9-11ce-8c82-00aa004ba90b");
        public static Guid IID_ITravelLogStg = new Guid("7EBFDD80-AD18-11d3-A4C5-00C04F72D6B8");
        public static Guid SID_STravelLogCursor = new Guid("7EBFDD80-AD18-11d3-A4C5-00C04F72D6B8");

    }

    /// <summary>
    ///
    /// </summary>
    public sealed class URLPOLICY
    {

        /// <summary>
        ///
        /// </summary>
        public const int CREDENTIALS_SILENT_LOGON_OK = unchecked(0x00000000);

        /// <summary>
        ///
        /// </summary>
        public const int CREDENTIALS_MUST_PROMPT_USER = unchecked(0x00010000);

        /// <summary>
        ///
        /// </summary>
        public const int CREDENTIALS_CONDITIONAL_PROMPT = unchecked(0x00020000);

        /// <summary>
        ///
        /// </summary>
        public const int CREDENTIALS_ANONYMOUS_ONLY = unchecked(0x00030000);

        /// <summary>
        ///
        /// </summary>
        public const int AUTHENTICATE_CLEARTEXT_OK = unchecked(0x00000000);

        /// <summary>
        ///
        /// </summary>
        public const int AUTHENTICATE_CHALLENGE_RESPONSE = unchecked(0x00010000);

        /// <summary>
        ///
        /// </summary>
        public const int AUTHENTICATE_MUTUAL_ONLY = unchecked(0x00030000);

        /// <summary>
        ///
        /// </summary>
        public const int JAVA_PROHIBIT = unchecked(0x00000000);

        /// <summary>
        ///
        /// </summary>
        public const int JAVA_HIGH = unchecked(0x00010000);

        /// <summary>
        ///
        /// </summary>
        public const int JAVA_MEDIUM = unchecked(0x00020000);

        /// <summary>
        ///
        /// </summary>
        public const int JAVA_LOW = unchecked(0x00030000);

        /// <summary>
        ///
        /// </summary>
        public const int JAVA_CUSTOM = unchecked(0x00800000);

        /// <summary>
        ///
        /// </summary>
        public const int JAVA_CURR_MAX = unchecked(0x00001C00);

        /// <summary>
        ///
        /// </summary>
        public const int JAVA_MAX = unchecked(0x00001Cff);

        /// <summary>
        ///
        /// </summary>
        public const int ALLOW = unchecked(0x00);

        /// <summary>
        ///
        /// </summary>
        public const int QUERY = unchecked(0x01);

        /// <summary>
        ///
        /// </summary>
        public const int DISALLOW = unchecked(0x03);

        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_ON_ALLOW = unchecked(0x10);

        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_ON_DISALLOW = unchecked(0x20);

        /// <summary>
        ///
        /// </summary>
        public const int LOG_ON_ALLOW = unchecked(0x40);

        /// <summary>
        ///
        /// </summary>
        public const int LOG_ON_DISALLOW = unchecked(0x80);

        /// <summary>
        ///
        /// </summary>
        public const int MASK_PERMISSIONS = unchecked(0x0f);

        /// <summary>
        ///
        /// </summary>
        public const int DONTCHECKDLGBOX = unchecked(0x100);
    }

    public sealed class URLACTION
    {
        public const int MIN = unchecked(0x00001000);

        public const int DOWNLOAD_MIN = unchecked(0x00001000);
        public const int DOWNLOAD_SIGNED_ACTIVEX = unchecked(0x00001001);
        public const int DOWNLOAD_UNSIGNED_ACTIVEX = unchecked(0x00001004);
        public const int DOWNLOAD_CURR_MAX = unchecked(0x00001004);
        public const int DOWNLOAD_MAX = unchecked(0x000011FF);

        public const int ACTIVEX_MIN = unchecked(0x00001200);
        public const int ACTIVEX_RUN = unchecked(0x00001200);
        public const int ACTIVEX_CHECK_LIST = unchecked(0x00010000);
        public const int ACTIVEX_OVERRIDE_OBJECT_SAFETY = unchecked(0x00001201);
        public const int ACTIVEX_OVERRIDE_DATA_SAFETY = unchecked(0x00001202);
        public const int ACTIVEX_OVERRIDE_SCRIPT_SAFETY = unchecked(0x00001203);
        public const int SCRIPT_OVERRIDE_SAFETY = unchecked(0x00001401);
        public const int ACTIVEX_CONFIRM_NOOBJECTSAFETY = unchecked(0x00001204);
        public const int ACTIVEX_TREATASUNTRUSTED = unchecked(0x00001205);
        public const int ACTIVEX_NO_WEBOC_SCRIPT = unchecked(0x00001206);
        public const int ACTIVEX_CURR_MAX = unchecked(0x00001206);
        public const int ACTIVEX_MAX = unchecked(0x000013ff);

        public const int SCRIPT_MIN = unchecked(0x00001400);
        public const int SCRIPT_RUN = unchecked(0x00001400);
        public const int SCRIPT_JAVA_USE = unchecked(0x00001402);
        public const int SCRIPT_SAFE_ACTIVEX = unchecked(0x00001405);
        public const int CROSS_DOMAIN_DATA = unchecked(0x00001406);
        public const int SCRIPT_PASTE = unchecked(0x00001407);
        public const int SCRIPT_CURR_MAX = unchecked(0x00001407);
        public const int SCRIPT_MAX = unchecked(0x000015ff);

        public const int HTML_MIN = unchecked(0x00001600);
        public const int HTML_SUBMIT_FORMS = unchecked(0x00001601);
        public const int HTML_SUBMIT_FORMS_FROM = unchecked(0x00001602);
        public const int HTML_SUBMIT_FORMS_TO = unchecked(0x00001603);
        public const int HTML_FONT_DOWNLOAD = unchecked(0x00001604);
        public const int HTML_JAVA_RUN = unchecked(0x00001605);
        public const int HTML_USERDATA_SAVE = unchecked(0x00001606);
        public const int HTML_SUBFRAME_NAVIGATE = unchecked(0x00001607);
        public const int HTML_META_REFRESH = unchecked(0x00001608);
        public const int HTML_MIXED_CONTENT = unchecked(0x00001609);
        public const int HTML_MAX = unchecked(0x000017ff);

        public const int SHELL_MIN = unchecked(0x00001800);
        public const int SHELL_INSTALL_DTITEMS = unchecked(0x00001800);
        public const int SHELL_MOVE_OR_COPY = unchecked(0x00001802);
        public const int SHELL_FILE_DOWNLOAD = unchecked(0x00001803);
        public const int SHELL_VERB = unchecked(0x00001804);
        public const int SHELL_WEBVIEW_VERB = unchecked(0x00001805);
        public const int SHELL_SHELLEXECUTE = unchecked(0x00001806);
        public const int SHELL_CURR_MAX = unchecked(0x00001806);
        public const int SHELL_MAX = unchecked(0x000019ff);

        public const int NETWORK_MIN = unchecked(0x00001A00);

        public const int CREDENTIALS_USE = unchecked(0x00001A00);
        public const int AUTHENTICATE_CLIENT = unchecked(0x00001A01);

        public const int COOKIES = unchecked(0x00001A02);
        public const int COOKIES_SESSION = unchecked(0x00001A03);

        public const int CLIENT_CERT_PROMPT = unchecked(0x00001A04);

        public const int COOKIES_THIRD_PARTY = unchecked(0x00001A05);
        public const int COOKIES_SESSION_THIRD_PARTY = unchecked(0x00001A06);

        public const int COOKIES_ENABLED = unchecked(0x00001A10);

        public const int NETWORK_CURR_MAX = unchecked(0x00001A10);
        public const int NETWORK_MAX = unchecked(0x00001Bff);

        public const int JAVA_MIN = unchecked(0x00001C00);
        public const int JAVA_PERMISSIONS = unchecked(0x00001C00);

        public const int INFODELIVERY_MIN = unchecked(0x00001D00);
        public const int INFODELIVERY_NO_ADDING_CHANNELS = unchecked(0x00001D00);
        public const int INFODELIVERY_NO_EDITING_CHANNELS = unchecked(0x00001D01);
        public const int INFODELIVERY_NO_REMOVING_CHANNELS = unchecked(0x00001D02);
        public const int INFODELIVERY_NO_ADDING_SUBSCRIPTIONS = unchecked(0x00001D03);
        public const int INFODELIVERY_NO_EDITING_SUBSCRIPTIONS = unchecked(0x00001D04);
        public const int INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS = unchecked(0x00001D05);
        public const int INFODELIVERY_NO_CHANNEL_LOGGING = unchecked(0x00001D06);
        public const int INFODELIVERY_CURR_MAX = unchecked(0x00001D06);
        public const int INFODELIVERY_MAX = unchecked(0x00001Dff);
        public const int CHANNEL_SOFTDIST_MIN = unchecked(0x00001E00);
        public const int CHANNEL_SOFTDIST_PERMISSIONS = unchecked(0x00001E05);
        public const int CHANNEL_SOFTDIST_PROHIBIT = unchecked(0x00010000);
        public const int CHANNEL_SOFTDIST_PRECACHE = unchecked(0x00020000);
        public const int CHANNEL_SOFTDIST_AUTOINSTALL = unchecked(0x00030000);
        public const int CHANNEL_SOFTDIST_MAX = unchecked(0x00001Eff);
    }

    /// <summary>
    ///
    /// </summary>
    public sealed class URLZONE
    {

        /// <summary>
        ///
        /// </summary>
        public const int LOCAL_MACHINE = 0;

        /// <summary>
        ///
        /// </summary>
        public const int INTRANET = LOCAL_MACHINE + 1;

        /// <summary>
        ///
        /// </summary>
        public const int TRUSTED = INTRANET + 1;

        /// <summary>
        ///
        /// </summary>
        public const int INTERNET = TRUSTED + 1;

        /// <summary>
        ///
        /// </summary>
        public const int UNTRUSTED = INTERNET + 1;
    }

    [
        ComImport,
        GuidAttribute("79eac9ee-baf9-11ce-8c82-00aa004ba90b"),
        InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown),
        ComVisible(false)
    ]
    public interface IInternetSecurityManager
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetSecuritySite([In] IInternetSecurityMgrSite pSite);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetSecuritySite([Out] IInternetSecurityMgrSite pSite);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int MapUrlToZone([In, MarshalAs(UnmanagedType.LPWStr)] String pwszUrl, out int pdwZone, int dwFlags);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetSecurityId([MarshalAs(UnmanagedType.LPWStr)] string pwszUrl,
                          [MarshalAs(UnmanagedType.LPArray)] byte[] pbSecurityId, ref uint pcbSecurityId, uint dwReserved);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int ProcessUrlAction([In, MarshalAs(UnmanagedType.LPWStr)] String pwszUrl, int dwAction, out byte pPolicy,
                             int cbPolicy, byte pContext, int cbContext, int dwFlags, int dwReserved);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int QueryCustomPolicy([In, MarshalAs(UnmanagedType.LPWStr)] String pwszUrl, ref Guid guidKey, byte ppPolicy,
                              int pcbPolicy, byte pContext, int cbContext, int dwReserved);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetZoneMapping(int dwZone, [In, MarshalAs(UnmanagedType.LPWStr)] String lpszPattern, int dwFlags);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetZoneMappings(int dwZone, out IEnumString ppenumString, int dwFlags);
    }

    [
       ComImport,
       GuidAttribute("79eac9ed-baf9-11ce-8c82-00aa004ba90b"),
       InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown),
       ComVisible(false)
    ]
    public interface IInternetSecurityMgrSite
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetWindow(out IntPtr hwnd);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int EnableModeless([In, MarshalAs(UnmanagedType.Bool)] Boolean fEnable);
    }

    /// <summary>
    /// Represents the properties of an IUri object
    /// </summary>
    public enum URI_PROPERTY
    {

        URI_PROPERTY_ABSOLUTE_URI = 0,
        URI_PROPERTY_AUTHORITY,
        URI_PROPERTY_DISPLAY_URI,
        URI_PROPERTY_DOMAIN,
        URI_PROPERTY_EXTENSION,
        URI_PROPERTY_FRAGMENT,
        URI_PROPERTY_HOST,
        URI_PROPERTY_PASSWORD,
        URI_PROPERTY_PATH,
        URI_PROPERTY_PATH_AND_QUERY,
        URI_PROPERTY_QUERY,
        URI_PROPERTY_RAW_URI,
        URI_PROPERTY_SCHEME_NAME,
        URI_PROPERTY_USER_INFO,
        URI_PROPERTY_USER_NAME,
        URI_PROPERTY_STRING_LAST,
        URI_PROPERTY_HOST_TYPE,
        URI_PROPERTY_DWORD_START,
        URI_PROPERTY_PORT,
        URI_PROPERTY_SCHEME,
        URI_PROPERTY_ZONE,

    };

    /// <summary>
    /// Static class to handle the parsing and creation
    /// of IUri objects from urls
    /// </summary>
    public static class ParseUri
    {

        /// <summary>
        /// Creates a new IUri object from a given url
        /// </summary>
        /// <param name="Uri">Url string</param>
        /// <param name="Flags">Flags to pass</param>
        /// <param name="Reserved">Reserved balues</param>
        /// <param name="pUri">Pointer to the new IUri</param>
        /// <returns></returns>
        [DllImport("urlmon.dll", SetLastError = true)]
        private static extern int
            CreateUri([MarshalAs(UnmanagedType.LPWStr)]string Uri,
            int Flags,
            int Reserved,
            [MarshalAs(UnmanagedType.Interface)] out IUri pUri);

        /// <summary>
        /// Creates a new IUri object from a url
        /// </summary>
        /// <param name="url">Url of a web object</param>
        /// <returns>IUri object for the given url</returns>
        public static IUri Create(string url)
        {

            //
            //  Create a new null IUri object
            //

            IUri uri = null;

            //
            //  Let the system create a new IUri for the
            //  passed url and set uri to its value
            //

            int createUriResult = CreateUri(url, 0, 0, out uri);

            //
            //  Return the new IUri instance
            //

            return uri;

        }

    }

    /// <summary>
    /// Interface wrapper around the IUri object
    /// </summary>
    [ComImport]
    [Guid("A39EE748-6A27-4817-A6F2-13914BEF5890")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IUri
    {

        /// <summary>
        /// Get string value for a speficic property from
        /// the URI_PROPERTY enum
        /// </summary>
        /// <param name="uriProp">Uri property</param>
        /// <param name="pbstrProperty">String property output</param>
        /// <param name="dwFlags">Flags</param>
        /// <returns>Success value</returns>
        int GetPropertyBSTR(
            URI_PROPERTY uriProp,
            [MarshalAs(UnmanagedType.BStr)]  string pbstrProperty,
            uint dwFlags
            );

        /// <summary>
        /// Get the length for a specific property
        /// </summary>
        /// <param name="uriProp">Uri property</param>
        /// <param name="pcchProperty">Property length</param>
        /// <param name="dwFlags">Flags</param>
        /// <returns>Success value</returns>
        int GetPropertyLength(URI_PROPERTY uriProp,
            out int pcchProperty,
            int dwFlags);

        /// <summary>
        /// <summary>
        /// Get DWORD value for a speficic property from
        /// the URI_PROPERTY enum
        /// </summary>
        /// <param name="uriProp">Uri property</param>
        /// <param name="pdwProperty">DWORD property output</param>
        /// <param name="dwFlags">Flags</param>
        /// <returns>Success value</returns>
        int GetPropertyDWORD(URI_PROPERTY uriProp,
            out int pdwProperty,
            int dwFlags);

        /// <summary>
        /// Checks if an URI has a specific property
        /// </summary>
        /// <param name="uriProp">Uri property</param>
        /// <param name="pfHasProperty">Exists boolean</param>
        /// <returns>Success value</returns>
        int HasProperty(
            URI_PROPERTY uriProp,
            out bool pfHasProperty
            );

        /// <summary>
        /// Get the absolute uri
        /// </summary>
        /// <param name="pbstrAbsoluteUri">Output string</param>
        /// <returns>Success value</returns>
        int GetAbsoluteUri(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrAbsoluteUri
            );

        /// <summary>
        /// Get the authority
        /// </summary>
        /// <param name="pbstrAuthority">Output string</param>
        /// <returns>Success value</returns>
        int GetAuthority(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrAuthority
            );

        /// <summary>
        /// Get the display uri
        /// </summary>
        /// <param name="pbstrDisplayString">Output string</param>
        /// <returns>Success value</returns>
        int GetDisplayUri(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrDisplayString
            );

        /// <summary>
        /// Get the domain
        /// </summary>
        /// <param name="pbDomain">Output string</param>
        /// <returns>Success value</returns>
        int GetDomain(
            [MarshalAs(UnmanagedType.BStr)] out string pbDomain
            );

        /// <summary>
        /// Get the extension
        /// </summary>
        /// <param name="pbstrExtension">Output string</param>
        /// <returns>Success value</returns>
        int GetExtension(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrExtension
            );

        /// <summary>
        /// Get the fragment
        /// </summary>
        /// <param name="pbstrFragment">Output string</param>
        /// <returns>Success value</returns>
        int GetFragment(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrFragment
            );

        /// <summary>
        /// Get the host
        /// </summary>
        /// <param name="pbstrHost">Output string</param>
        /// <returns>Success value</returns>
        int GetHost(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrHost
            );

        /// <summary>
        /// Get the password
        /// </summary>
        /// <param name="pbPassword">Output string</param>
        /// <returns>Success value</returns>
        int GetPassword(
            [MarshalAs(UnmanagedType.BStr)] out string pbPassword
            );

        /// <summary>
        /// Get the path
        /// </summary>
        /// <param name="pbstrPath">Output string</param>
        /// <returns>Success value</returns>
        int GetPath(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrPath
            );

        /// <summary>
        /// Get the path and query
        /// </summary>
        /// <param name="pbstrPathAndQuery">Output string</param>
        /// <returns>Success value</returns>
        int GetPathAndQuery(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrPathAndQuery
            );

        /// <summary>
        /// Get the query
        /// </summary>
        /// <param name="pbstrQuery">Output string</param>
        /// <returns>Success value</returns>
        int GetQuery(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrQuery
            );

        /// <summary>
        /// Get the raw uri
        /// </summary>
        /// <param name="pbstrRawUri"></param>
        /// <returns>Success value</returns>
        int GetRawUri(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrRawUri
            );

        /// <summary>
        /// Get the scheme name
        /// </summary>
        /// <param name="pbstrSchemeName">Output string</param>
        /// <returns>Success value</returns>
        int GetSchemeName(
            [MarshalAs(UnmanagedType.BStr)] out string pbstrSchemeName
            );

        /// <summary>
        /// Get the user info
        /// </summary>
        /// <param name="pbuserInfo">Output string</param>
        /// <returns>Success value</returns>
        int GetUserInfo(
            [MarshalAs(UnmanagedType.BStr)] out string pbuserInfo
            );

        /// <summary>
        /// Get the user name
        /// </summary>
        /// <param name="pbuserName">Output string</param>
        /// <returns>Success value</returns>
        int GetUserName(
            [MarshalAs(UnmanagedType.BStr)] out string pbuserName
            );

        /// <summary>
        /// Get the host type
        /// </summary>
        /// <param name="pdwHostType">Output int</param>
        /// <returns>Success value</returns>
        int GetHostType(
            out int pdwHostType
            );

        /// <summary>
        /// Get the port
        /// </summary>
        /// <param name="pdwPort">Output int</param>
        /// <returns>Success value</returns>
        int GetPort(
            out int pdwPort
            );

        /// <summary>
        /// Get the scheme
        /// </summary>
        /// <param name="pdwScheme">Output int</param>
        /// <returnsSuccess value></returns>
        int GetScheme(
            out int pdwScheme
            );

        /// <summary>
        /// Get the zone
        /// </summary>
        /// <param name="pdwZone">Output int</param>
        /// <returns>Success value</returns>
        int GetZone(
            out int pdwZone
            );

        /// <summary>
        /// Get the available properties
        /// </summary>
        /// <param name="pdwFlags">Output int</param>
        /// <returns>Success value</returns>
        int GetProperties(
            out int pdwFlags
            );

        /// <summary>
        /// Compares two IUri objects for equality
        /// </summary>
        /// <param name="pUri">Reference Uri</param>
        /// <param name="pfEqual">Equality</param>
        /// <returns>Success value</returns>
        int IsEqual(
            ref IUri pUri,
            out bool pfEqual
            );

    };

    [
       ComImport,
       GuidAttribute("6d5140c1-7436-11ce-8034-00aa006009fa"),
       InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown),
       ComVisible(false)
    ]
    public interface IServiceProvider
    {

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int QueryService(ref Guid guidService, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObject);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int QueryService(
            [In] ref Guid guidService,
            [In] ref Guid riid,
            [Out] out IntPtr ppvObject);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int QueryService(ref Guid guidService, ref Guid riid,
                         [MarshalAs(UnmanagedType.Interface)] out IInternetSecurityManager ppvObject);
    }

    [
   ComImport,
   GuidAttribute("cb728b20-f786-11ce-92ad-00aa00a74cd0"),
   InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown),
   ComVisible(false)
]
    public interface IProfferService
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int ProfferService(ref Guid guidService, IServiceProvider psp, ref int cookie);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int RevokeService(int cookie);

    }

    [ComVisible(true), ComImport()]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("7EBFDD85-AD18-11d3-A4C5-00C04F72D6B8")]
    public interface IEnumTravelLogEntry
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Next(
            [In, MarshalAs(UnmanagedType.U4)] int celt,
            [Out] out ITravelLogEntry rgelt,
            [Out, MarshalAs(UnmanagedType.U4)] out int pceltFetched);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Skip([In, MarshalAs(UnmanagedType.U4)] int celt);

        void Reset();

        void Clone([Out] out ITravelLogEntry ppenum);
    }

    [ComVisible(true), ComImport()]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("F46EDB3C-BC2F-11D0-9412-00AA00A3EBD3")]
    public interface ITravelLog
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int AddEntry([In, MarshalAs(UnmanagedType.IUnknown)] object punk,
            [In, MarshalAs(UnmanagedType.Bool)] bool IsLocalAnchor);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int UpdateEntry([In, MarshalAs(UnmanagedType.IUnknown)] object punk,
            [In, MarshalAs(UnmanagedType.Bool)] bool IsLocalAnchor);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int UpdateExternal([In, MarshalAs(UnmanagedType.IUnknown)] object punk,
            [In, MarshalAs(UnmanagedType.IUnknown)] object punkHLBrowseContext);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Travel([In, MarshalAs(UnmanagedType.IUnknown)] object punk,
            [In] int iOffset);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetTravelEntry([In, MarshalAs(UnmanagedType.IUnknown)] object punk,
            [Out] out ITravelLogEntry Entry);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int FindTravelEntry([In, MarshalAs(UnmanagedType.IUnknown)] object punk,
             [In] IntPtr Pidl,
            [Out] out ITravelLogEntry Entry);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int CountEntries([In, MarshalAs(UnmanagedType.IUnknown)] object punk);

    }

    [ComVisible(true), ComImport()]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("7EBFDD87-AD18-11d3-A4C5-00C04F72D6B8")]
    public interface ITravelLogEntry
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetTitle([Out] out IntPtr ppszTitle); //LPOLESTR LPWSTR

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetURL([Out] out IntPtr ppszURL); //LPOLESTR LPWSTR
    }

    [ComVisible(true), ComImport()]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("7EBFDD80-AD18-11d3-A4C5-00C04F72D6B8")]
    public interface ITravelLogStg
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int CreateEntry([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszTitle,
            [In] ITravelLogEntry ptleRelativeTo,
            [In, MarshalAs(UnmanagedType.Bool)] bool fPrepend,
            [Out] out ITravelLogEntry pptle);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int TravelTo([In] ITravelLogEntry ptle);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int EnumEntries([In] int TLENUMF_flags, [Out] out IEnumTravelLogEntry ppenum);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int FindEntries([In] int TLENUMF_flags,
        [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
        [Out] out IEnumTravelLogEntry ppenum);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetCount([In] int TLENUMF_flags, [Out] out int pcEntries);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int RemoveEntry([In] ITravelLogEntry ptle);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetRelativeEntry([In] int iOffset, [Out] out ITravelLogEntry ptle);
    }

}
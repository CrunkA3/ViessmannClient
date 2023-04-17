﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViessmannClient.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ViessmannClient.Tests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die {
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;isEnabled&quot;: true,
        ///      &quot;isReady&quot;: true,
        ///      &quot;gatewayId&quot;: &quot;{GatewayId}&quot;,
        ///      &quot;feature&quot;: &quot;heating.boiler.temperature&quot;,
        ///      &quot;deviceId&quot;: &quot;{DeviceId}&quot;,
        ///      &quot;timestamp&quot;: &quot;2020-03-23T12:19:28.688Z&quot;,
        ///      &quot;properties&quot;: {
        ///        &quot;value&quot;: {
        ///          &quot;type&quot;: &quot;number&quot;,
        ///          &quot;value&quot;: 47.6
        ///        }
        ///      },
        ///      &quot;commands&quot;: {},
        ///      &quot;components&quot;: []
        ///    },
        ///    {
        ///      &quot;isEnabled&quot;: true,
        ///      &quot;isReady&quot;: true,
        ///      &quot;gatewayId&quot;: &quot;{GatewayId}&quot;,
        ///      &quot;fea [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string DeviceFeatures {
            get {
                return ResourceManager.GetString("DeviceFeatures", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die {
        ///	&quot;data&quot;: [
        ///		{
        ///			&quot;gatewaySerial&quot;: &quot;{GatewayId}&quot;,
        ///			&quot;id&quot;: &quot;{DeviceId}&quot;,
        ///			&quot;boilerSerial&quot;: &quot;777555888999&quot;,
        ///			&quot;boilerSerialEditor&quot;: &quot;DeviceCommunication&quot;,
        ///			&quot;bmuSerial&quot;: &quot;000999888777&quot;,
        ///			&quot;bmuSerialEditor&quot;: &quot;DeviceCommunication&quot;,
        ///			&quot;createdAt&quot;: &quot;2018-06-08T00:08:10.199Z&quot;,
        ///			&quot;editedAt&quot;: &quot;2019-11-08T20:53:43.470Z&quot;,
        ///			&quot;modelId&quot;: &quot;VPlusHO1_40&quot;,
        ///			&quot;status&quot;: &quot;Online&quot;,
        ///			&quot;deviceType&quot;: &quot;heating&quot;
        ///		}
        ///	]
        ///} ähnelt.
        /// </summary>
        internal static string Devices {
            get {
                return ResourceManager.GetString("Devices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die {
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;isEnabled&quot;: true,
        ///      &quot;isReady&quot;: true,
        ///      &quot;{GatewayId}&quot;: &quot;{GatewayId}&quot;,
        ///      &quot;feature&quot;: &quot;gateway.bmuconnection&quot;,
        ///      &quot;timestamp&quot;: &quot;2020-03-23T19:54:09.825Z&quot;,
        ///      &quot;properties&quot;: {
        ///        &quot;status&quot;: {
        ///          &quot;type&quot;: &quot;string&quot;,
        ///          &quot;value&quot;: &quot;OK&quot;
        ///        }
        ///      },
        ///      &quot;commands&quot;: {},
        ///      &quot;components&quot;: []
        ///    },
        ///    {
        ///      &quot;isEnabled&quot;: true,
        ///      &quot;isReady&quot;: true,
        ///      &quot;{GatewayId}&quot;: &quot;{GatewayId}&quot;,
        ///      &quot;feature&quot;: &quot;gateway.devices&quot;,
        ///       [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string GatewayFeatures {
            get {
                return ResourceManager.GetString("GatewayFeatures", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die {
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;serial&quot;: &quot;{GatewayId}&quot;,
        ///      &quot;version&quot;: &quot;1.4.0.0&quot;,
        ///      &quot;firmwareUpdateFailureCounter&quot;: 0,
        ///      &quot;autoUpdate&quot;: false,
        ///      &quot;createdAt&quot;: &quot;2016-08-01T16:34:22.856Z&quot;,
        ///      &quot;producedAt&quot;: &quot;2016-08-01T14:40:28.000Z&quot;,
        ///      &quot;lastStatusChangedAt&quot;: &quot;2020-03-22T06:07:56.595Z&quot;,
        ///      &quot;aggregatedStatus&quot;: &quot;WorksProperly&quot;,
        ///      &quot;targetRealm&quot;: &quot;Genesis&quot;,
        ///      &quot;gatewayType&quot;: &quot;VitoconnectOptolink&quot;,
        ///      &quot;installationId&quot;: {InstallationId},
        ///      &quot;registeredAt&quot;: &quot;2017-01-29T18:1 [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string Gateways {
            get {
                return ResourceManager.GetString("Gateways", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die {
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;id&quot;: {InstallationId},
        ///      &quot;description&quot;: null,
        ///      &quot;address&quot;: {
        ///        &quot;street&quot;: &quot;Long test street&quot;,
        ///        &quot;houseNumber&quot;: &quot;1001&quot;,
        ///        &quot;zip&quot;: &quot;12345&quot;,
        ///        &quot;city&quot;: &quot;Unittest Town&quot;,
        ///        &quot;region&quot;: null,
        ///        &quot;country&quot;: &quot;de&quot;,
        ///        &quot;phoneNumber&quot;: null,
        ///        &quot;faxNumber&quot;: null,
        ///        &quot;geolocation&quot;: {
        ///          &quot;latitude&quot;: 37.377166,
        ///          &quot;longitude&quot;: -122.086966,
        ///          &quot;timeZone&quot;: &quot;Europe/Berlin&quot;
        ///        }
        ///      },
        ///      &quot;registe [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string Installations {
            get {
                return ResourceManager.GetString("Installations", resourceCulture);
            }
        }
    }
}

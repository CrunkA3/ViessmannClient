﻿using ViessmannClient.Model.Devices;
using ViessmannClient.Model.Features;
using ViessmannClient.Model.Gateways;
using ViessmannClient.Model.Installations;
using ViessmannClient.Network;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViessmannClient.Model.Commands;
using ViessmannClient.Model;

namespace ViessmannClient
{
    public class ViessmannPlatformClient : ViessmannAuthBase
    {
        private const string _baseUri = "https://api.viessmann.com/";

        public ViessmannPlatformClient(IViessmannConnectionProvider<ViessmannPlatformClient> connectionProvider)
            : base(connectionProvider) { }

        public async Task<IEnumerable<Installation>> GetInstallations()
        {
            var uri = $"{_baseUri}iot/v1/equipment/installations";
            return await CallViessmannApi<InstallationResponse, List<Installation>>(new Uri(uri));
        }

        public async Task<IEnumerable<Gateway>> GetGateways(long installationId)
        {
            var uri = $"{_baseUri}iot/v1/equipment/installations/{installationId}/gateways";
            return await CallViessmannApi<GatewayResponse, List<Gateway>>(new Uri(uri));
        }

        public async Task<IEnumerable<Device>> GetDevices(long installationId, long gatewayId)
        {
            var uri = $"{_baseUri}iot/v1/equipment/installations/{installationId}/gateways/{gatewayId}/devices";
            return await CallViessmannApi<DeviceResponse, List<Device>>(new Uri(uri));
        }

        public async Task<GatewayFeatureList> GetGatewayFeatures(long installationId, long gatewayId)
        {
            var uri = $"{_baseUri}iot/v1/equipment/installations/{installationId}/gateways/{gatewayId}/features";
            return await CallViessmannApi<FeatureResponse<GatewayFeatureList>, GatewayFeatureList>(new Uri(uri));
        }

        public async Task<DeviceFeatureList> GetDeviceFeatures(long installationId, long gatewayId, long deviceId = 0)
        {
            var uri = $"{_baseUri}iot/v1/equipment/installations/{installationId}/gateways/{gatewayId}/devices/{deviceId}/features";
            return await CallViessmannApi<FeatureResponse<DeviceFeatureList>, DeviceFeatureList>(new Uri(uri));
        }

        public async Task<SuccessState> ExecuteDeviceFeatureCommand<T>(long installationId, long gatewayId, long deviceId, string featureName, CommandContent<T> commandBody)
        {
            var uri = $"{_baseUri}iot/v1/equipment/installations/{installationId}/gateways/{gatewayId}/devices/{deviceId}/features/{featureName}";
            return await CallViessmannApi<CommandResponse<SuccessState>, SuccessState, CommandContent<T>>(new Uri(uri), commandBody);
        }
    }
}
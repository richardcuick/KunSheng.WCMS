import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'WCMS',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44391/',
    redirectUri: baseUrl,
    clientId: 'WCMS_App',
    responseType: 'code',
    scope: 'offline_access WCMS',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44391',
      rootNamespace: 'KunSheng.WCMS',
    },
  },
} as Environment;

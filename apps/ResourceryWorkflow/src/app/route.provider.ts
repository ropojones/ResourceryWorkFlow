import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '',
        iconClass: '',
        order: 0,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/dashboard',
        name: 'Workflow::Dashboard',
        iconClass: '',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/dashboard',
        name: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/directorate',
        name: 'Workflow::Directorate',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 0,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/translation',
        name: 'Workflow::Translation',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/interpretation',
        name: 'Workflow::Interpretation',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/conference',
        name: 'Workflow::Conference',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 3,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/protocol',
        name: 'Workflow::Protocol',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 4,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/dashboard',
        name: 'Workflow::Transcription',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 5,
        layout: eLayoutType.application,
      },
      {
        path: '/resourcery/dashboard',
        name: 'Workflow::Support',
        order: 4,
        layout: eLayoutType.application,
      },

    ]);
  };
}

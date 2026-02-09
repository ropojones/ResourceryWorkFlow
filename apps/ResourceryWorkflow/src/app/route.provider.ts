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
        path: '/dashboard',
        name: 'Workflow::Dashboard',
        iconClass: '',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/dashboard',
        name: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/directorate',
        name: 'Workflow::Directorate',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 0,
        layout: eLayoutType.application,
      },
       {
        path: '/directorate/internal-memoranda',
        name: 'Workflow::InternalMemoranda',
        parentName: 'Workflow::Directorate',
        iconClass: '',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/translation',
        name: 'Workflow::Translation',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/interpretation',
        name: 'Workflow::Interpretation',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/conference',
        name: 'Workflow::Conference',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 3,
        layout: eLayoutType.application,
      },
      {
        path: '/protocol',
        name: 'Workflow::Protocol',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 4,
        layout: eLayoutType.application,
      },
      {
        path: '/transcription',
        name: 'Workflow::Transcription',
        parentName: 'Workflow::ServiceRequests',
        iconClass: '',
        order: 5,
        layout: eLayoutType.application,
      },
      {
        path: '/support',
        name: 'Workflow::Support',
        order: 4,
        layout: eLayoutType.application,
      },

    ]);
  };
}

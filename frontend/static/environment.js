window.exclude = [];
  window.watch = false;
  window.environment = 'release';
  window.localMode = 'build';

  window.appConfig = {
    showDebugger: false,
    showExperimentalFeatures: false,
    workspaces: [
      {
        id: 'local',
        label: 'local',
        projectGraphUrl: 'project-graph.json',
        taskGraphUrl: 'task-graph.json'
      }
    ],
    defaultWorkspaceId: 'local',
  };
  window.projectGraphResponse = {"hash":"516fb7ec721a2e16ca6732a0013a106d6949a9e9b1083d4fb2225f4b728b11e0","projects":[{"name":"intern-rapp-e2e","type":"e2e","data":{"tags":[],"root":"apps/intern-rapp-e2e","files":[{"file":"apps/intern-rapp-e2e/.eslintrc.json","hash":"4c5989b23b5aa8cc7aba2a07d1ae7daee19c1555"},{"file":"apps/intern-rapp-e2e/cypress.config.ts","hash":"22f7c84eb637d4f23447fcb59dee130dd25b2de0","deps":["npm:cypress","npm:@nrwl/cypress"]},{"file":"apps/intern-rapp-e2e/project.json","hash":"efc01472a253dd61c666e4a31459ffb715ce73ae"},{"file":"apps/intern-rapp-e2e/src/e2e/app.cy.ts","hash":"d760ff81e18f879ff26aeb5a6a26ea2f4b33e2b6"},{"file":"apps/intern-rapp-e2e/src/fixtures/example.json","hash":"294cbed6ce9e0b948b787452e8676aee486cb3be"},{"file":"apps/intern-rapp-e2e/src/support/app.po.ts","hash":"32934246969c2ecb827ac05677785933a707a54d"},{"file":"apps/intern-rapp-e2e/src/support/commands.ts","hash":"310f1fa0e043ffebbbcf575c5a4d17f13a6b14d6"},{"file":"apps/intern-rapp-e2e/src/support/e2e.ts","hash":"3d469a6b6cf31eb66117d73e278bcf74f398f1db"},{"file":"apps/intern-rapp-e2e/tsconfig.json","hash":"9e27f75c6fadf5f6175f48ca953d551089aef787"}],"targets":{"e2e":{"inputs":["default","^production"],"executor":"@nrwl/cypress:cypress","options":{"cypressConfig":"apps/intern-rapp-e2e/cypress.config.ts","devServerTarget":"intern-rapp:serve:development","testingType":"e2e"},"configurations":{"production":{"devServerTarget":"intern-rapp:serve:production"}}},"lint":{"inputs":["default","{workspaceRoot}/.eslintrc.json","{workspaceRoot}/.eslintignore"],"executor":"@nrwl/linter:eslint","outputs":["{options.outputFile}"],"options":{"lintFilePatterns":["apps/intern-rapp-e2e/**/*.{js,ts}"]},"configurations":{}}}}},{"name":"intern-rapp","type":"app","data":{"tags":[],"root":"apps/intern-rapp","files":[{"file":"apps/intern-rapp/.eslintrc.json","hash":"9485eb3c3b265b624fe2c38bb52c5075168e555f"},{"file":"apps/intern-rapp/jest.config.ts","hash":"be0fe7689160f647ccced0d66fc425cb26e76539"},{"file":"apps/intern-rapp/project.json","hash":"41e07a2a56adf69f31868387f716e5f6a0edac35"},{"file":"apps/intern-rapp/src/app/app.component.html","hash":"2e22c3d106bb4259680e606013288c3a36d0c1eb"},{"file":"apps/intern-rapp/src/app/app.component.scss","hash":"e69de29bb2d1d6434b8b29ae775ad8c2e48c5391"},{"file":"apps/intern-rapp/src/app/app.component.spec.ts","hash":"262bb171d65044987ca62df96c5bf284da8d9ced","deps":["npm:@angular/core","npm:@angular/router"]},{"file":"apps/intern-rapp/src/app/app.component.ts","hash":"d577a3ab8c3583044dc480d8f4db9a9de858d90c","deps":["npm:@angular/router","npm:@angular/core","npm:@angular/material","npm:@angular/forms","npm:@angular/common","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/app.routes.ts","hash":"51c9560bf4038108a60e5894dcc0e100cb9f3707","deps":["npm:@angular/cdk","npm:@angular/router"]},{"file":"apps/intern-rapp/src/app/baselist/baselist.component.scss","hash":"e69de29bb2d1d6434b8b29ae775ad8c2e48c5391"},{"file":"apps/intern-rapp/src/app/baselist/baselist.component.spec.ts","hash":"e6fd25980ee58c8c0dc142602ad170d2dc0594e8","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/baselist/baselist.component.ts","hash":"d8df87a101a6e0b0c2831440f3a9dea935e4df1e","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:rxjs","npm:@angular/forms"]},{"file":"apps/intern-rapp/src/app/baselist/baseList.ts","hash":"a930fad207836f0dca77337dc17039e4cb141b42","deps":["npm:@angular/material","npm:rxjs"]},{"file":"apps/intern-rapp/src/app/baselist/baselistcomponent.html","hash":"72891ca2d0074dad408107104342087d3e936557"},{"file":"apps/intern-rapp/src/app/configurations/APIConfiguration.ts","hash":"e4173f78fcefbb6adb520e06aeadeeeba5a97140"},{"file":"apps/intern-rapp/src/app/delete-popup/delete-popup.component.html","hash":"ccaf0a260b61bbf9dcf1601474cc64c830efaa7b"},{"file":"apps/intern-rapp/src/app/delete-popup/delete-popup.component.scss","hash":"7b44d45305fc60d3b4d7980cce70ac5bd733a683"},{"file":"apps/intern-rapp/src/app/delete-popup/delete-popup.component.spec.ts","hash":"92a7943562a60d8d7ad482eef68a64c9c4d4433e","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/delete-popup/delete-popup.component.ts","hash":"d3c3e0dba215b85c79aeb05d3451fed57e42d6eb","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@angular/forms","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/department-add-popup/department-add-popup.component.html","hash":"298e5a4c348ba6197aeea7b805d59085bfffe1d1"},{"file":"apps/intern-rapp/src/app/department-add-popup/department-add-popup.component.scss","hash":"5f52c62b1cccd4b13fef357407963aca4a10ee86"},{"file":"apps/intern-rapp/src/app/department-add-popup/department-add-popup.component.spec.ts","hash":"60a43caf91bb95b13a87b0fb861a0bffe7591ba6","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/department-add-popup/department-add-popup.component.ts","hash":"893c74346082b471dcd7b3108cf47d8dc23dd19b","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@angular/forms","npm:rxjs","npm:@angular/cdk","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/department-update/department-update.component.html","hash":"13257e4bb76115cc868d7675c71f0e3fbc30ad80"},{"file":"apps/intern-rapp/src/app/department-update/department-update.component.scss","hash":"f4172594f2f47cd3fedd2c9624beed19cda8cd72"},{"file":"apps/intern-rapp/src/app/department-update/department-update.component.spec.ts","hash":"1fb1fbce159860902ba1895bcfce7f4448cdb498","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/department-update/department-update.component.ts","hash":"27f39b5613b33dea06a0e35f1050b6d0754e6b34","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@angular/forms","npm:@angular/cdk","npm:rxjs","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/entities/CreateDepartment.ts","hash":"41c7bddd0a8ab96ebbb74ed60567cdfbe6ac12ba"},{"file":"apps/intern-rapp/src/app/entities/createLanguage.ts","hash":"f4b7dfd9ba18d9475ba68d3f84a0ac4f984a4e14"},{"file":"apps/intern-rapp/src/app/entities/createLocation.ts","hash":"210a798cd615c725f39f43ccbe0c84f2ab76acee"},{"file":"apps/intern-rapp/src/app/entities/departmentItem.ts","hash":"458eb3659f876bb352172133ca8fa37909f1f305"},{"file":"apps/intern-rapp/src/app/entities/displayColumns.ts","hash":"2c09ee64679a753d09f5c0fe9b5d6b74fa003b18"},{"file":"apps/intern-rapp/src/app/entities/filter.ts","hash":"0e631be0a41d9488b6e115a951d96a6cc8531430","deps":["npm:rxjs"]},{"file":"apps/intern-rapp/src/app/entities/languageItem.ts","hash":"15b6ef24ea0ae239ae6dc91d0c7644122e881e43"},{"file":"apps/intern-rapp/src/app/entities/locationItem.ts","hash":"1fec6105dfd50b996a751c3fbbb1c4c61d4684ac"},{"file":"apps/intern-rapp/src/app/entities/paginationFilterRequest.ts","hash":"b47c8f2e73db160bc43e3cfd52c11d5517048d35"},{"file":"apps/intern-rapp/src/app/entities/paginationRequest.ts","hash":"73e7d74ba6836f3a9d39d42b49d0eee0e1c69f60"},{"file":"apps/intern-rapp/src/app/entities/resourceItemPagingResponse.ts","hash":"0888107df72ecf847b78a82e1246c3b9521dd7ed"},{"file":"apps/intern-rapp/src/app/entities/user.ts","hash":"2bf1f65e2402ef2182a55e621f6131a3753fb48f"},{"file":"apps/intern-rapp/src/app/enums/filterType.ts","hash":"814622cc1d50e55a28b64102c6ef25fe41471caf"},{"file":"apps/intern-rapp/src/app/enums/languageDropdownOptions.ts","hash":"4ea14c8f24953440c9a24416af1eeec362edfa4b"},{"file":"apps/intern-rapp/src/app/filter/filter.component.html","hash":"7fb2069010c79b7a6d5461fa2e0e34dea7a432df"},{"file":"apps/intern-rapp/src/app/filter/filter.component.scss","hash":"2b57c67d32bf7a49e137d98e4eea06b8d2ce7d31"},{"file":"apps/intern-rapp/src/app/filter/filter.component.spec.ts","hash":"86b78f4b0fe62d07b175e79ef0f8b25e9ea7ce42","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/filter/filter.component.ts","hash":"d11ec77017e317e2299f91c44512fe31ad361a66","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/forms","npm:@angular/material"]},{"file":"apps/intern-rapp/src/app/injectionTokens/LOCALE_ID.ts","hash":"d4aacfa10cc8477c0536357efbb887c7ed68c996","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/interceptors/accept-header.interceptor.spec.ts","hash":"e4df3dfe24c4d1d97e51883dfba1aa2c8052b995","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/interceptors/accept-header.interceptor.ts","hash":"a2d20189c56548932fe3f1f25debc64bfd045702","deps":["npm:@angular/core","npm:@angular/common","npm:rxjs"]},{"file":"apps/intern-rapp/src/app/items-tmpl-context.ts","hash":"3eef191a80b250becfbffc3c012b9e60315238c6"},{"file":"apps/intern-rapp/src/app/items-tmpl.directive.spec.ts","hash":"5e9d3b9db80425b258074535e2d93ba044b292e2"},{"file":"apps/intern-rapp/src/app/items-tmpl.directive.ts","hash":"0e5aaf4c9c79a71d19c3d7dace783cafee543494","deps":["npm:@angular/core","npm:rxjs"]},{"file":"apps/intern-rapp/src/app/language-add-popup/language-add-popup.component.html","hash":"fbb261f58818203aa2d793bfbdf0529b8ebf4966"},{"file":"apps/intern-rapp/src/app/language-add-popup/language-add-popup.component.scss","hash":"e0ccb4c3a6a1ed7ddd13e0f1d1d0e240bbc5894a"},{"file":"apps/intern-rapp/src/app/language-add-popup/language-add-popup.component.spec.ts","hash":"20056ab22dd515cace9628beb45ee9cf4e2b9ef0","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/language-add-popup/language-add-popup.component.ts","hash":"a44393c94191efcbb087cf95c765f8ae23b01774","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@angular/forms","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/language-dropdown/language-dropdown.component.html","hash":"d6f86fe17dade74ff8324fa1863c07305777479a"},{"file":"apps/intern-rapp/src/app/language-dropdown/language-dropdown.component.scss","hash":"e69de29bb2d1d6434b8b29ae775ad8c2e48c5391"},{"file":"apps/intern-rapp/src/app/language-dropdown/language-dropdown.component.spec.ts","hash":"a52ffb28f5bfd35f3250ee5e83fa568c5c32027f","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/language-dropdown/language-dropdown.component.ts","hash":"37d9c82b0c161f1aef84668e46908dafedf1a9ee","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/language-list/language-list.component.html","hash":"19ee1d724444d68ad727f883ae772fa03a7938d5"},{"file":"apps/intern-rapp/src/app/language-list/language-list.component.scss","hash":"4af95f61f2369d632ed655c90f6526889a91c006"},{"file":"apps/intern-rapp/src/app/language-list/language-list.component.spec.ts","hash":"d2bd7a58a4d9b9ab9d1d39464445a14ab46c1c20","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/language-list/language-list.component.ts","hash":"104e5edbc07617ff0908204933021acb4e151d45","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:rxjs","npm:@angular/forms","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/language-update-popup/language-update-popup.component.html","hash":"3e70ba8a246048f88f749bd8e83ae7cd69568d66"},{"file":"apps/intern-rapp/src/app/language-update-popup/language-update-popup.component.scss","hash":"c97182afe6b58b29cae586ede7de7e0a24f91768"},{"file":"apps/intern-rapp/src/app/language-update-popup/language-update-popup.component.spec.ts","hash":"da0c5fa315e1ce2050b26a3fd16fbb7d8bbce559","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/language-update-popup/language-update-popup.component.ts","hash":"3c355f319303c3c8507648a15b8d28b3506251d0","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@angular/forms","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/loader/customTranslate.ts","hash":"b34f8660cab722b6a9e0a37551d37e599c6bd267","deps":["npm:@angular/common","npm:@ngx-translate/core","npm:rxjs"]},{"file":"apps/intern-rapp/src/app/location-add-popup/location-add-popup.component.html","hash":"067639077383f7f4bc51d26935d687dbe209734a"},{"file":"apps/intern-rapp/src/app/location-add-popup/location-add-popup.component.scss","hash":"60c1ca14cc95b1224dc3f327378e7ab200df89eb"},{"file":"apps/intern-rapp/src/app/location-add-popup/location-add-popup.component.spec.ts","hash":"247ea61b1f7baa18a8239721bb87d4f0b0ec81e9","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/location-add-popup/location-add-popup.component.ts","hash":"09e7c99111eb750204205830be7b21804ed6321e","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/forms","npm:@angular/material","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/location-list/location-list.component.html","hash":"1513be8dd19d1eaa5252bc7681beff3c34485ffd"},{"file":"apps/intern-rapp/src/app/location-list/location-list.component.scss","hash":"4af95f61f2369d632ed655c90f6526889a91c006"},{"file":"apps/intern-rapp/src/app/location-list/location-list.component.spec.ts","hash":"fe7b24f963ad1c91ca7da851df4444892f8f5ec7","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/location-list/location-list.component.ts","hash":"c231b960f2bc63d0874774460c8f23a2e2485ce8","deps":["npm:@angular/core","npm:@angular/common","npm:rxjs","npm:@angular/material","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/location-update-popup/location-update-popup.component.html","hash":"f1d63a4ede3ea86b375b27b52914990e32a84455"},{"file":"apps/intern-rapp/src/app/location-update-popup/location-update-popup.component.scss","hash":"21f73e8b7e380ec2370158512832fce31ab1aed1"},{"file":"apps/intern-rapp/src/app/location-update-popup/location-update-popup.component.spec.ts","hash":"9b27c0c0500f3779683c8afb8d457d2aef134f6c","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/location-update-popup/location-update-popup.component.ts","hash":"92487fb43c50e9bfaf1bb1cd47998846dee98a1a","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/forms","npm:@angular/material","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/navbar/navbar.component.html","hash":"01e84327c3efc7647746f1ecb1b46ec0ff6413ab"},{"file":"apps/intern-rapp/src/app/navbar/navbar.component.scss","hash":"ed7d7a2212b3f072ec0266d3fb12ab2895752b84"},{"file":"apps/intern-rapp/src/app/navbar/navbar.component.spec.ts","hash":"c8eb82634cf2eb828f60ed06621e31394e5e4f49","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/navbar/navbar.component.ts","hash":"d083133e75e21c5f0297172a9af947134718ec35","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@angular/router","npm:rxjs","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/app/nx-welcome.component.ts","hash":"1375b382f7f74835ac0cc7b9fff094d22fa42a58","deps":["npm:@angular/core","npm:@angular/common"]},{"file":"apps/intern-rapp/src/app/services/department.service.spec.ts","hash":"10ebd891654ba49daf06c19bd93936f0bb60084b","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/services/department.service.ts","hash":"907d6cf0b7a4247f4cbdabb03a0b2fb49350d23f","deps":["npm:@angular/core","npm:@angular/common","npm:rxjs"]},{"file":"apps/intern-rapp/src/app/services/language.service.spec.ts","hash":"299455eea3144b0463c7fed0b2756b27b3aebb1f","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/services/language.service.ts","hash":"b0f4c5206bc448a2b1094c2beeea1052fb7fc19b","deps":["npm:@angular/core","npm:@angular/common","npm:rxjs"]},{"file":"apps/intern-rapp/src/app/services/location.service.spec.ts","hash":"49dca003678f564fc59cc28d5d1b1299d32d39e5","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/services/location.service.ts","hash":"ee15f8e79487e45a7b520c471122163675391512","deps":["npm:@angular/common","npm:@angular/core","npm:rxjs"]},{"file":"apps/intern-rapp/src/app/unit-list/unit-list.component.html","hash":"62841fa80a6d87bcac034a4052253aa4aed2219c"},{"file":"apps/intern-rapp/src/app/unit-list/unit-list.component.scss","hash":"dc79ad95bbd59db7f5a7ab5b8339587abc2b4d8c"},{"file":"apps/intern-rapp/src/app/unit-list/unit-list.component.spec.ts","hash":"917e58c856c5fc8d3ae2ebc9aa062132c5e83b37","deps":["npm:@angular/core"]},{"file":"apps/intern-rapp/src/app/unit-list/unit-list.component.ts","hash":"cc5af7d0d4c5de117a9c2fe9288daa26e8575e01","deps":["npm:@angular/core","npm:@angular/common","npm:@angular/forms","npm:@angular/material","npm:rxjs","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/assets/.gitkeep","hash":"e69de29bb2d1d6434b8b29ae775ad8c2e48c5391"},{"file":"apps/intern-rapp/src/favicon.ico","hash":"317ebcb2336e0833a22dddf0ab287849f26fda57"},{"file":"apps/intern-rapp/src/index.html","hash":"4499cbba7af3feffb0d5becc9fbe2dfc3554445e"},{"file":"apps/intern-rapp/src/main.ts","hash":"81b63273b56b155b29a91c1f4123aa979a09c506","deps":["npm:@angular/platform-browser","npm:@angular/router","npm:@angular/core","npm:@angular/common","npm:@angular/material","npm:@ngx-translate/core"]},{"file":"apps/intern-rapp/src/styles.scss","hash":"f18245a206645696debfd8dbd92b3722cb34ce8d"},{"file":"apps/intern-rapp/src/test-setup.ts","hash":"1100b3e8a6ed08f4b5c27a96471846d57023c320","deps":["npm:jest-preset-angular"]},{"file":"apps/intern-rapp/tsconfig.app.json","hash":"fff4a41d444a486d4cf163be19f8601e0510c270"},{"file":"apps/intern-rapp/tsconfig.editor.json","hash":"8ae117d96293c675141bebfc2fad8c5df58429d3"},{"file":"apps/intern-rapp/tsconfig.json","hash":"e01cf19bd9d5ff6c8db1b3c2e180e5d79e6999b1"},{"file":"apps/intern-rapp/tsconfig.spec.json","hash":"f6a7d97bb8d04fb3cb2ddeab186d1e2a0a560a13"}],"targets":{"build":{"dependsOn":["^build"],"inputs":["production","^production"],"executor":"@angular-devkit/build-angular:browser","outputs":["{options.outputPath}"],"options":{"outputPath":"dist/apps/intern-rapp","index":"apps/intern-rapp/src/index.html","main":"apps/intern-rapp/src/main.ts","polyfills":["zone.js"],"tsConfig":"apps/intern-rapp/tsconfig.app.json","inlineStyleLanguage":"scss","assets":["apps/intern-rapp/src/favicon.ico","apps/intern-rapp/src/assets"],"styles":["apps/intern-rapp/src/styles.scss"],"scripts":[]},"configurations":{"production":{"budgets":[{"type":"initial","maximumWarning":"500kb","maximumError":"1mb"},{"type":"anyComponentStyle","maximumWarning":"2kb","maximumError":"4kb"}],"outputHashing":"all"},"development":{"buildOptimizer":false,"optimization":false,"vendorChunk":true,"extractLicenses":false,"sourceMap":true,"namedChunks":true}},"defaultConfiguration":"production"},"serve":{"executor":"@angular-devkit/build-angular:dev-server","configurations":{"production":{"browserTarget":"intern-rapp:build:production"},"development":{"browserTarget":"intern-rapp:build:development"}},"defaultConfiguration":"development"},"extract-i18n":{"executor":"@angular-devkit/build-angular:extract-i18n","options":{"browserTarget":"intern-rapp:build"}},"lint":{"inputs":["default","{workspaceRoot}/.eslintrc.json","{workspaceRoot}/.eslintignore"],"executor":"@nrwl/linter:eslint","outputs":["{options.outputFile}"],"options":{"lintFilePatterns":["apps/intern-rapp/**/*.ts","apps/intern-rapp/**/*.html"]},"configurations":{}},"test":{"inputs":["default","^production","{workspaceRoot}/jest.preset.js"],"executor":"@nrwl/jest:jest","outputs":["{workspaceRoot}/coverage/{projectRoot}"],"options":{"jestConfig":"apps/intern-rapp/jest.config.ts","passWithNoTests":true},"configurations":{"ci":{"ci":true,"codeCoverage":true}}}}}},{"name":"common-ui","type":"lib","data":{"tags":[],"root":"libs/common-ui","files":[{"file":"libs/common-ui/.eslintrc.json","hash":"9485eb3c3b265b624fe2c38bb52c5075168e555f"},{"file":"libs/common-ui/jest.config.ts","hash":"a6178b1448359cef7342a61dc769316ee36e6284"},{"file":"libs/common-ui/project.json","hash":"9d61859c9ecf75a92b628f47e977be30ef7b09f9"},{"file":"libs/common-ui/README.md","hash":"f2a6bbc606cf6f1f6dfb5bcaa56a9916a234e0b9"},{"file":"libs/common-ui/src/index.ts","hash":"3b5ad4f196f08258d4b975be38215377f262b05e"},{"file":"libs/common-ui/src/lib/common-ui.module.ts","hash":"de31813562e8e43e801f55110f433ee1a51d9a18","deps":["npm:@angular/core","npm:@angular/common"]},{"file":"libs/common-ui/src/test-setup.ts","hash":"1100b3e8a6ed08f4b5c27a96471846d57023c320","deps":["npm:jest-preset-angular"]},{"file":"libs/common-ui/tsconfig.json","hash":"92049739f65e6a89dcd34bca26e34e0cafefc690"},{"file":"libs/common-ui/tsconfig.lib.json","hash":"c6d50ba84b33edc435d17ae15e9260b24b278ef7"},{"file":"libs/common-ui/tsconfig.spec.json","hash":"f6a7d97bb8d04fb3cb2ddeab186d1e2a0a560a13"}],"targets":{"test":{"inputs":["default","^production","{workspaceRoot}/jest.preset.js"],"executor":"@nrwl/jest:jest","outputs":["{workspaceRoot}/coverage/{projectRoot}"],"options":{"jestConfig":"libs/common-ui/jest.config.ts","passWithNoTests":true},"configurations":{"ci":{"ci":true,"codeCoverage":true}}},"lint":{"inputs":["default","{workspaceRoot}/.eslintrc.json","{workspaceRoot}/.eslintignore"],"executor":"@nrwl/linter:eslint","outputs":["{options.outputFile}"],"options":{"lintFilePatterns":["libs/common-ui/**/*.ts","libs/common-ui/**/*.html"]},"configurations":{}}}}}],"dependencies":{"intern-rapp-e2e":[{"source":"intern-rapp-e2e","target":"intern-rapp","type":"implicit"}],"intern-rapp":[],"common-ui":[]},"layout":{"appsDir":"apps","libsDir":"libs"},"affected":[],"focus":null,"groupByFolder":false,"exclude":[]};
    window.taskGraphResponse = {"taskGraphs":{"intern-rapp-e2e:e2e":{"roots":["intern-rapp-e2e:e2e"],"tasks":{"intern-rapp-e2e:e2e":{"id":"intern-rapp-e2e:e2e","target":{"project":"intern-rapp-e2e","target":"e2e"},"projectRoot":"apps/intern-rapp-e2e","overrides":{}}},"dependencies":{"intern-rapp-e2e:e2e":[]}},"intern-rapp-e2e:e2e:production":{"roots":["intern-rapp-e2e:e2e:production"],"tasks":{"intern-rapp-e2e:e2e:production":{"id":"intern-rapp-e2e:e2e:production","target":{"project":"intern-rapp-e2e","target":"e2e","configuration":"production"},"projectRoot":"apps/intern-rapp-e2e","overrides":{}}},"dependencies":{"intern-rapp-e2e:e2e:production":[]}},"intern-rapp-e2e:lint":{"roots":["intern-rapp-e2e:lint"],"tasks":{"intern-rapp-e2e:lint":{"id":"intern-rapp-e2e:lint","target":{"project":"intern-rapp-e2e","target":"lint"},"projectRoot":"apps/intern-rapp-e2e","overrides":{}}},"dependencies":{"intern-rapp-e2e:lint":[]}},"intern-rapp:build":{"roots":["intern-rapp:build:production"],"tasks":{"intern-rapp:build:production":{"id":"intern-rapp:build:production","target":{"project":"intern-rapp","target":"build","configuration":"production"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:build:production":[]}},"intern-rapp:build:production":{"roots":["intern-rapp:build:production"],"tasks":{"intern-rapp:build:production":{"id":"intern-rapp:build:production","target":{"project":"intern-rapp","target":"build","configuration":"production"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:build:production":[]}},"intern-rapp:build:development":{"roots":["intern-rapp:build:development"],"tasks":{"intern-rapp:build:development":{"id":"intern-rapp:build:development","target":{"project":"intern-rapp","target":"build","configuration":"development"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:build:development":[]}},"intern-rapp:serve":{"roots":["intern-rapp:serve:development"],"tasks":{"intern-rapp:serve:development":{"id":"intern-rapp:serve:development","target":{"project":"intern-rapp","target":"serve","configuration":"development"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:serve:development":[]}},"intern-rapp:serve:production":{"roots":["intern-rapp:serve:production"],"tasks":{"intern-rapp:serve:production":{"id":"intern-rapp:serve:production","target":{"project":"intern-rapp","target":"serve","configuration":"production"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:serve:production":[]}},"intern-rapp:serve:development":{"roots":["intern-rapp:serve:development"],"tasks":{"intern-rapp:serve:development":{"id":"intern-rapp:serve:development","target":{"project":"intern-rapp","target":"serve","configuration":"development"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:serve:development":[]}},"intern-rapp:extract-i18n":{"roots":["intern-rapp:extract-i18n"],"tasks":{"intern-rapp:extract-i18n":{"id":"intern-rapp:extract-i18n","target":{"project":"intern-rapp","target":"extract-i18n"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:extract-i18n":[]}},"intern-rapp:lint":{"roots":["intern-rapp:lint"],"tasks":{"intern-rapp:lint":{"id":"intern-rapp:lint","target":{"project":"intern-rapp","target":"lint"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:lint":[]}},"intern-rapp:test":{"roots":["intern-rapp:test"],"tasks":{"intern-rapp:test":{"id":"intern-rapp:test","target":{"project":"intern-rapp","target":"test"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:test":[]}},"intern-rapp:test:ci":{"roots":["intern-rapp:test:ci"],"tasks":{"intern-rapp:test:ci":{"id":"intern-rapp:test:ci","target":{"project":"intern-rapp","target":"test","configuration":"ci"},"projectRoot":"apps/intern-rapp","overrides":{}}},"dependencies":{"intern-rapp:test:ci":[]}},"common-ui:test":{"roots":["common-ui:test"],"tasks":{"common-ui:test":{"id":"common-ui:test","target":{"project":"common-ui","target":"test"},"projectRoot":"libs/common-ui","overrides":{}}},"dependencies":{"common-ui:test":[]}},"common-ui:test:ci":{"roots":["common-ui:test:ci"],"tasks":{"common-ui:test:ci":{"id":"common-ui:test:ci","target":{"project":"common-ui","target":"test","configuration":"ci"},"projectRoot":"libs/common-ui","overrides":{}}},"dependencies":{"common-ui:test:ci":[]}},"common-ui:lint":{"roots":["common-ui:lint"],"tasks":{"common-ui:lint":{"id":"common-ui:lint","target":{"project":"common-ui","target":"lint"},"projectRoot":"libs/common-ui","overrides":{}}},"dependencies":{"common-ui:lint":[]}}},"errors":{}};
    
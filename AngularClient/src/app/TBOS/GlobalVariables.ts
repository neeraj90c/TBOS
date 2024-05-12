'use strict';

import { environment } from "src/environments/environment";


 export const BaseURL : string = environment.apiURL;
 export const TBOS_BaseURL : string = BaseURL+'/TBOS/' ;

//#region Customer Master API 

export const getAllCustomers = TBOS_BaseURL + 'CustomerMaster/ReadAll'
export const getAllCustomersPaginated = TBOS_BaseURL + 'CustomerMaster/ReadAllPaginated'

//#endregion
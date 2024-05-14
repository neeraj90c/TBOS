'use strict';

import { environment } from "src/environments/environment";


export const BaseURL: string = environment.apiURL;
export const TBOS_BaseURL: string = BaseURL + '/TBOS/';
export const Auth_BaseURL: string = BaseURL + '/users/';
export const Menu_BaseURL: string = BaseURL + '/menus/';


//#region Authentication API
export const Auth = Auth_BaseURL + 'auth'
export const ValidateToken = Auth_BaseURL + 'ValidateToken'


//#endregion

//#region Menu API
export const getMenuForUser = Menu_BaseURL + 'GetMenuForUser'


//#endregion




//#region Customer Master API 

export const getAllCustomers = TBOS_BaseURL + 'CustomerMaster/ReadAll'
export const getAllCustomersPaginated = TBOS_BaseURL + 'CustomerMaster/ReadAllPaginated'

//#endregion
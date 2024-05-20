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

//#region Transport Master API 
export const getAllBranch = TBOS_BaseURL + 'BranchMaster/ReadAll'
export const getAllBranchPaginated = TBOS_BaseURL + 'BranchMaster/ReadAllPaginated'
export const createBranch = TBOS_BaseURL + 'BranchMaster/Create'
export const updateBranch = TBOS_BaseURL + 'BranchMaster/Update'
export const getBranchById = TBOS_BaseURL + 'BranchMaster/ReadById'
export const getBranchByCompanyId = TBOS_BaseURL + 'BranchMaster/ReadByCompanyId'
export const deleteBranch = TBOS_BaseURL + 'BranchMaster/Delete'
//#endregion

//#region Customer Master API 
export const getAllCustomers = TBOS_BaseURL + 'CustomerMaster/ReadAll'
export const getAllCustomersPaginated = TBOS_BaseURL + 'CustomerMaster/ReadAllPaginated'
export const createCustomer = TBOS_BaseURL + 'CustomerMaster/Create'
export const updateCustomer = TBOS_BaseURL + 'CustomerMaster/Update'
export const getCustomerById = TBOS_BaseURL + 'CustomerMaster/ReadById'
export const deleteCustomer = TBOS_BaseURL + 'CustomerMaster/Delete'
//#endregion

//#region Agent Master API 
export const getAllAgents = TBOS_BaseURL + 'AgentMaster/ReadAll'
export const getAllAgentsPaginated = TBOS_BaseURL + 'AgentMaster/ReadAllPaginated'
export const createAgent = TBOS_BaseURL + 'AgentMaster/Create'
export const updateAgent = TBOS_BaseURL + 'AgentMaster/Update'
export const getAgentById = TBOS_BaseURL + 'AgentMaster/ReadById'
export const deleteAgent = TBOS_BaseURL + 'AgentMaster/Delete'
//#endregion

//#region Transport Master API 
export const getAllTransport = TBOS_BaseURL + 'TransportMaster/ReadAll'
export const getAllTransportsPaginated = TBOS_BaseURL + 'TransportMaster/ReadAllPaginated'
export const createTransport = TBOS_BaseURL + 'TransportMaster/Create'
export const updateTransport = TBOS_BaseURL + 'TransportMaster/Update'
export const getTransportById = TBOS_BaseURL + 'TransportMaster/ReadById'
export const deleteTransport = TBOS_BaseURL + 'TransportMaster/Delete'
//#endregion
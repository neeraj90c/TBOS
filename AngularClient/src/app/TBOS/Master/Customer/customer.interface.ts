import { PaginatedDTO } from "../../common.interface";

export interface CustomerMasterDTO {
    customerId: number;
    customerCode: string;
    customerName: string;
    transportId: number;
    agentId?: number;
    paymentTerm?: number;
    branchId?: number;
    customerBranch: string;
    status?: number;
    taxForm: string;
    tin_No: string;
    agentCommission?: number;
    paymentDay: string;
    creditDaysLock?: number;
    cstTinNo: string;
    customerType: string;
    defaultPrice: string;
    defaultInvoice: string;
    creditAmountLock?: number;
    panNo: string;
    priority: string;
    customerRemarks: string;
    cgst: string;
    sgst: string;
    igst: string;
    utgst: string;
    gstiN_No: string;
    gSTReverseCharge: string;
    exportGST: string;
    createdBy?: string;
    createdOn?: Date;
    modifiedBy: string;
    modifiedOn?: Date;
    isActive: number;
    isDeleted: number;
}
export interface CustomerMasterDTOPaginated extends PaginatedDTO {
    customerId: number;
    customerCode: string;
    customerName: string;
    transportId: number;
    agentId?: number;
    paymentTerm?: number;
    branchId?: number;
    customerBranch: string;
    status?: number;
    taxForm: string;
    tin_No: string;
    agentCommission?: number;
    paymentDay: string;
    creditDaysLock?: number;
    cstTinNo: string;
    customerType: string;
    defaultPrice: string;
    defaultInvoice: string;
    creditAmountLock?: number;
    panNo: string;
    priority: string;
    customerRemarks: string;
    cgst: string;
    sgst: string;
    igst: string;
    utgst: string;
    gstiN_No: string;
    gSTReverseCharge: string;
    exportGST: string;
    createdBy?: string;
    createdOn?: Date;
    modifiedBy: string;
    modifiedOn?: Date;
    isActive: number;
    isDeleted: number;
    detailId: number;
    masterCode: string;
    addressType: string;
    add_line1: string;
    add_line2: string;
    add_line3: string;
    add_line4: string;
    city: string;
    state: string;
    country: string;
    pincode: string;
    addressStatus: number;
    contactId?: number;
    personName?: string;
    designation?: string;
    phoneNumber?: string;
    mobileNumber?: string;
    emailId?: string;
    contactStatus?: number;
    agentName?: string
    transportName?: string
}

export interface CreateCustomer {
    customerName: string;
    transportId: number;
    agentId?: number;
    paymentTerm: number;
    branchId: number;
    customerBranch: string;
    status: number;
    taxForm: string;
    tin_No: string;
    agentCommission: number;
    paymentDay: string;
    creditDaysLock: number;
    cstTinNo: string;
    customerType: string;
    defaultPrice: string;
    defaultInvoice: string;
    creditAmountLock: number;
    panNo: string;
    priority: string;
    customerRemarks: string;
    cGST: string;
    sGST: string;
    iGST: string;
    uTGST: string;
    gSTIN_No: string;
    gSTReverseCharge: string;
    exportGST: string;
    actionUser: string;
}

export interface UpdateCustomer {
    customerId: number;
    customerName: string;
    transportId: number;
    agentId: number;
    paymentTerm: number;
    branchId: number;
    customerBranch: string;
    status: number;
    taxForm: string;
    tin_No: string;
    agentCommission?: number;
    paymentDay: string;
    creditDaysLock: number;
    cstTinNo: string;
    customerType: string;
    defaultPrice: string;
    defaultInvoice: string;
    creditAmountLock: number;
    panNo: string;
    priority: string;
    customerRemarks: string;
    cGST: string;
    sGST: string;
    iGST: string;
    uTGST: string;
    gSTIN_No: string;
    gSTReverseCharge: string;
    exportGST: string;
    actionUser: string;
}

export interface DeleteCustomer {
    customerId: number;
    actionUser: string;
}

export interface CustomerList {
    items: CustomerMasterDTO[];
}

export interface CustomerListPaginated {
    items: CustomerMasterDTOPaginated[];
}

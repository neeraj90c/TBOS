export interface TransportMaster {
    transportId: number;
    transportName: string;
    branchCode: string;
    specialization: string;
    transportStatus: number;
    branchId: string;
    cgst: string;
    sgst: string;
    igst: string;
    utgst: string;
    gstiN_No: string;
    gstReverseCharge: string;
    createdBy: string;
    createdOn: Date;
    modifiedBy: string;
    modifiedOn: Date;
    isActive: number;
    isDeleted: number;
}

export interface TransportList {
    items: TransportMaster[]
}

export interface CreateTransport {
    transportName: string;
    branchCode: string;
    specialization: string;
    transportStatus: number;
    branchId: string;
    cgst: string;
    sgst: string;
    igst: string;
    utgst: string;
    gstiN_No: string;
    gstReverseCharge: string;
    actionUser: string;
}

export interface UpdateTransport {
    transportId: number;
    transportName: string;
    branchCode: string;
    specialization: string;
    transportStatus: number;
    branchId: string;
    cgst: string;
    sgst: string;
    igst: string;
    utgst: string;
    gstiN_No: string;
    gstReverseCharge: string;
    actionUser: string;
}

export interface DeleteTransport {
    transportId: number;
    actionUser: string;
}
export interface AgentMaster {
    agentId: number;
    agentName: string;
    agentStatus: number;
    panNo: string;
    zone: string;
    agentCommission: number;
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

export interface AgentList {
    items: AgentMaster[]
}

export interface CreateAgent {
    agentName: string;
    agentStatus: number;
    panNo: string;
    zone: string;
    agentCommission: number;
    branchId: string;
    cgst: string;
    sgst: string;
    igst: string;
    utgst: string;
    gstiN_No: string;
    gstReverseCharge: string;
    actionUser: string;
}

export interface UpdateAgent {
    agentId: number;
    agentName: string;
    agentStatus: number;
    panNo: string;
    zone: string;
    agentCommission: number;
    branchId: string;
    cgst: string;
    sgst: string;
    igst: string;
    utgst: string;
    gstiN_No: string;
    gstReverseCharge: string;
    actionUser: string;
}

export interface DeleteAgent {
    agentId: number;
    actionUser: string;
}

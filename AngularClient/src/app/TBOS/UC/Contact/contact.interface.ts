export interface ContactDetailDTO {
    contactId: number;
    masterCode: string;
    personName: string;
    designation: string;
    phoneNumber: string;
    mobileNumber: string;
    emailId: string;
    contactStatus: number;
    isActive?: number;
    createdOn?: Date;
    createdBy?: string;
    modifiedOn?: Date;
    modifiedBy?: string;
    isDeleted?: number;
}

export interface ContactList {
    items: ContactDetailDTO[]
}

export interface CreateContact {
    masterCode: string;
    personName: string;
    designation: string;
    phoneNumber: string;
    mobileNumber: string;
    emailId: string;
    contactStatus: number;
    actionUser: string;
}
export interface UpdateContact {
    contactId: number;
    masterCode: string;
    personName: string;
    designation: string;
    phoneNumber: string;
    mobileNumber: string;
    emailId: string;
    contactStatus: number;
    actionUser: string;
}
export interface DeleteContact {
    contactId: number;
    actionUser: string;
}

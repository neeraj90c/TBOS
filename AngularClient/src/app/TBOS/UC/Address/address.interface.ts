export interface AddressDetailDTO {
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
    status: number;
    createdBy?: string;
    createdOn?: Date;
    modifiedBy?: string;
    modifiedOn?: Date;
    isActive?: number;
    isDeleted?: number;
}

export interface AddressList {
    items: AddressDetailDTO[]
}

export interface CreateAddress {
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
    status: number;
    actionUser: string;
}
export interface UpdateAddress {
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
    status: number;
    actionUser: string;
}

export interface DeleteAddress {
    detailId: number;
    actionUser: string;
}
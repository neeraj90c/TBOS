export interface ValueListDTO {
    valueListId: number;
    vlName: string;
    vlCode: string | null;
    vlDesc: string | null;
    createdBy: string | null;
    createdOn: Date | null;
    modifiedBy: string | null;
    modifiedOn: Date | null;
    isActive: number | null;
    isDeleted: number | null;
}

export interface ValueListAll {
    items: ValueListDTO[];
}

export interface CreateValueList {
    vlName: string;
    vlCode?: string | null;
    vlDesc?: string | null;
    actionUser: string;
}

export interface UpdateValueList {
    valueListId: number;
    vlName: string;
    vlCode?: string | null;
    vlDesc?: string | null;
    actionUser: string;
}

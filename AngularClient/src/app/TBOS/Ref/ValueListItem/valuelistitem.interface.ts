export interface ValueListItemDTO {
    valueListItemId: number;
    valuesListId: number;
    vliName: string;
    vliCode: string | null;
    vliDesc: string | null;
    displaySeq: number;
    createdBy: string | null;
    createdOn: Date | null;
    modifiedBy: string | null;
    modifiedOn: Date | null;
    isActive: number | null;
    isDeleted: number | null;
}

export interface ValueListItemAll {
    items: ValueListItemDTO[];
}

export interface CreateValueListItem {
    valuesListId: number;
    vliName: string;
    vliCode?: string | null;
    vliDesc?: string | null;
    displaySeq: number;
    actionUser: string;
}

export interface UpdateValueListItem {
    valueListItemId: number;
    valuesListId: number;
    vliName: string;
    vliCode?: string | null;
    vliDesc?: string | null;
    displaySeq: number;
    actionUser: string;
}

export interface UserLoginDTO {
    userName: string;
    password: string;
    companyCode: string;
    firstName?: string;
    lastName?: string;
    azureUserId?: string;
    azureEmailId?: string;
    expiresOn: number;
}

export interface User {
    token: string,
    userId: number,
    profileImage: string,
    userName: string,
    userNameIntial: string,
    designation: string,
    emailId: string,
    mobileNo: string,
    roleId: string,
    companyId: string,
    defaultCompanyId: string
}
export interface UserResponseDTO {
    success: boolean;
    message: string;
    statusCode: number;
    data: User
}

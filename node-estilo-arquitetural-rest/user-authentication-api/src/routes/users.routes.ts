import { NextFunction, Request, Response, Router } from "express";
import { StatusCodes } from "http-status-codes";

const userRoute = Router();

userRoute.get('/users', (req: Request, res: Response, next: NextFunction) => {
    const users = [{ userName: 'teste username'}];
    res.status(StatusCodes.OK).send(users);
});

userRoute.get('/users/:uuid', (req: Request<{ uuid: String }>, res: Response, next: NextFunction) => {
    //O : na url informa ao typescript que este é um parâmetro que está sendo passado dentro da url.
    const uuid = req.params.uuid;   //recebe o parâmetro passado na url.
    res.status(StatusCodes.OK).send( {uuid} );
});

userRoute.post('/users', (req: Request, res: Response, next: NextFunction) => {
    const newUser = req.body;
    res.status(StatusCodes.CREATED).send(newUser);
});

userRoute.put('/users/:uuid', (req: Request<{ uuid: String }>, res: Response, next: NextFunction) => {
    const uuid = req.params.uuid;
    const modifiedUser = req.body;
    modifiedUser.uuid = uuid;
    res.status(StatusCodes.OK).send( {modifiedUser} );
});

userRoute.delete('/users/:uuid', (req: Request<{ uuid: String }>, res: Response, next: NextFunction) => {
    res.sendStatus(StatusCodes.OK);
});

export default userRoute;
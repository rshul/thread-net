import { Injectable } from '@angular/core';

import { Subject } from 'rxjs';
import { User } from '../models/user';
import { CommentComponent } from '../components/comment/comment.component';

// tslint:disable:member-ordering
@Injectable({ providedIn: 'root' })
export class EventService {
    private onUserChanged = new Subject<User>();
    private onCommentDeleted = new Subject<CommentComponent>();
    public userChangedEvent$ = this.onUserChanged.asObservable();
    public commentDeletedEvent$ = this.onCommentDeleted.asObservable();

    public userChanged(user: User) {
        this.onUserChanged.next(user);
    }
    public commentDeleted(comment: CommentComponent) {
        this.onCommentDeleted.next(comment);
    }
}

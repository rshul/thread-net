import { EventService } from 'src/app/services/event.service';
import { Component, Input, OnChanges } from '@angular/core';
import { Comment } from 'src/app/models/comment/comment';
import { User } from 'src/app/models/user';
import { NgOnChangesFeature } from '@angular/core/src/render3';
import { Post } from 'src/app/models/post/post';
import { AuthenticationService } from 'src/app/services/auth.service';
import { LikeService } from 'src/app/services/like.service';
import { Subject, Observable, empty } from 'rxjs';
import { takeUntil, switchMap, catchError } from 'rxjs/operators';
import { AuthDialogService } from 'src/app/services/auth-dialog.service';
import { DialogType } from 'src/app/models/common/auth-dialog-type';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent implements OnChanges {
    @Input() public comment: Comment;
    @Input() public currentUser: User;
    @Input() public post: Post;
    isOwnComment: boolean;
    private unsubscribe$ = new Subject<void>();
    
    constructor(
        private eventService: EventService,
        private authService: AuthenticationService,
        private likeService: LikeService,
        private authDialogService: AuthDialogService
         ) { }

    ngOnChanges(): void {
        if (this.currentUser) {
            this.isOwnComment = this.comment.author.id == this.currentUser.id;
        } else {
            this.isOwnComment = false;
        }
    }

    private commentDelete() {
        this.eventService.commentDeleted(this);
    }

    public likeComment() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.likeComment(this.comment, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((comment) => (this.comment = comment));

            return;
        }

        this.likeService
            .likeComment(this.comment, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((comment) => (this.comment = comment));
    }

    private catchErrorWrapper(obs: Observable<User>) {
        return obs.pipe(
            catchError(() => {
                this.openAuthDialog();
                return empty();
            })
        );
    }
    
    public openAuthDialog() {
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

}

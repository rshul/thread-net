import { EventService } from 'src/app/services/event.service';
import { Component, Input, OnChanges  } from '@angular/core';
import { Comment } from 'src/app/models/comment/comment';
import { User } from 'src/app/models/user';
import { NgOnChangesFeature } from '@angular/core/src/render3';
import { Post } from 'src/app/models/post/post';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent implements OnChanges{
    @Input() public comment: Comment;
    @Input() public currentUser: User;
    @Input() public post: Post;
    isOwnComment : boolean;

    constructor(private eventService : EventService){}

    ngOnChanges(): void {
        if (this.currentUser) {
            this.isOwnComment = this.comment.author.id == this.currentUser.id;
        } else {
            this.isOwnComment = false;
        }
    }
   private commentDelete(){
       this.eventService.commentDeleted(this);
   }
    
}

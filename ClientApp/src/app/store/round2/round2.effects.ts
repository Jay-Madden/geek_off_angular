import { Injectable } from '@angular/core';
import { Actions, createEffect, Effect, ofType } from '@ngrx/effects';
import { catchError, map, mergeMap, switchMap } from 'rxjs/operators';
import { round2AllSurvey, round2AllSurveySuccess } from './round2.actions';
import { DataService } from 'src/app/data.service';
import { of } from 'rxjs';

@Injectable()
export class Round2Effects {

  constructor(private actions$: Actions, private dataService: DataService) { }

  getRound2SurveyQuestions$ = createEffect(() => this.actions$.pipe(
    ofType(round2AllSurvey),
    switchMap(payload =>
      this.dataService.getAllRound2SurveyQuestions(payload.yEvent).pipe(map(surveyQuestions =>
        round2AllSurveySuccess({ allSurvey: surveyQuestions }) // todo: add catchError
      )))));
}

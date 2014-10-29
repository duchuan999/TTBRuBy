class DmnuocsxesController < ApplicationController
  helper_method :sort_column, :sort_direction
  respond_to :html, :js

  def index
    @dmnuocsxes  = Dmnuocsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    #@dmnuocsxes=Dmnuocsx.all#.paginate(:page => params[:page], :per_page => 12)
  end

  def show
    @dmnuocsx = Dmnuocsx.find(params[:id])
  end

  def edit
    @dmnuocsx = Dmnuocsx.find(params[:id])
  end

  def update
    @dmnuocsxes = Dmnuocsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)

    @dmnuocsx = Dmnuocsx.find(params[:id])
    @dmnuocsx.update_attributes(dmnuocsx_params)
  end

  def new
    @dmnuocsx = Dmnuocsx.new
  end

  def create
    @dmnuocsxes = Dmnuocsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    @dmnuocsx = Dmnuocsx.create(dmnuocsx_params)
  end

  def delete
    @dmnuocsx = Dmnuocsx.find(params[:dmnuocsx_id])
  end

  def destroy
    @dmnuocsxes = Dmnuocsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    @dmnuocsx = Dmnuocsx.find(params[:id])
    @dmnuocsx.destroy
  end

  private
  def dmnuocsx_params
    params.require(:dmnuocsx).permit(:stt,:ten,:dmnhomnuocsx_id)
  end

  def sort_column
    Dmnuocsx.column_names.include?(params[:sort]) ? params[:sort] : "ten"
  end
  def sort_direction
    %w[asc desc].include?(params[:direction]) ? params[:direction] : "asc"
  end
end
